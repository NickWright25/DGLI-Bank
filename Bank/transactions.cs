using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
namespace Bank
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        
        //Prevent window from being resized through title bar double click
        private void transactions_Resize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        //Prevent window from being resized when user left clicks and drags title bar
        protected override void WndProc(ref Message m)
        {
            int WM_NCLBUTTONDOWN = 0xA1;
            int WM_SYSCOMMAND = 0x112;
            int HTCAPTION = 0x02;
            int SC_MOVE = 0xF010;

            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == SC_MOVE)
                return;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
                return;

            base.WndProc(ref m);
        }

        private void PlaySound(string file)
        {
            SoundPlayer sound = new SoundPlayer(file);
            sound.Play();
        }

        //Function to check whether transaction number is valid and display corresponding amount
        public int balance = 0;
        public int transactionNumber = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int index = 0;
            string[] transactions = File.ReadAllLines($@"{Directory.GetCurrentDirectory()}\852-168-2.txt");
            bool usedCheck = false;
            foreach(string transaction in transactions)
            {
                if (transaction.ToLower() == txtTransaction.Text.ToLower())
                {
                    foreach(DataGridViewRow row in listTransactions.Rows)
                    {
                        string usedTransaction = Convert.ToString(row.Cells[1].Value);
                        if(transaction == usedTransaction)
                        {
                            usedCheck = true;
                        }
                    }
                    if (usedCheck == false)
                    {
                        transactionNumber++;
                        listTransactions.Rows.Add(transactionNumber, transaction, transactions[index + 1]);
                        balance += Convert.ToInt32(transactions[index + 1]);
                        lblBalance.Text = Convert.ToString(balance);
                        string file = $@"{Directory.GetCurrentDirectory()}\audio1.wav";
                        if (File.Exists(file))
                        {
                            PlaySound(file);
                        }
                    }
                    
                }
                index++;
            }
            if (lblBalance.Text == "1000000")
            {
                Congratulations CongratulationsForm = new Congratulations();
                CongratulationsForm.Show();

                string file = $@"{Directory.GetCurrentDirectory()}\audio2.wav";
                if (File.Exists(file))
                {
                    PlaySound(file);
                }
            }
            lblBalance.Text = string.Format("£{0:#.00}", Convert.ToDecimal(balance));

            if (txtTransaction.Text == "resetmenow!")
            {
                if (CheckFormOpen("login"))
                {
                    Form login = Application.OpenForms["login"];
                    login.Show();
                    Cleanup();
                    this.Hide();
                }
                else
                {
                    Login login = new Login();
                    login.Show();
                }
            }
            txtTransaction.Text = "";
        }
        bool CheckFormOpen(string formName)
        {
            foreach(Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        void Cleanup()
        {
            Clipboard.Clear();
            listTransactions.Rows.Clear();
            lblBalance.Text = "";
        }
    }
}