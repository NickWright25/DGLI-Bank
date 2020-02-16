using System;
using System.Windows.Forms;
namespace Bank
{
    public partial class transactions : Form
    {
        public transactions()
        {
            InitializeComponent();
        }
        private void transactions_Resize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        protected override void WndProc(ref Message m)
        {
            // Prevent form from resizing if user attempts to left click
            // on title bar of form and drag it
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

        public int balance = 0;
        public int transactionNumber = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int index = 0;
            string[] transactions = System.IO.File.ReadAllLines(@"C:\app\transactions.txt");
            bool usedCheck = false;
            foreach(string transaction in transactions)
            {
                if (transaction == txtTransaction.Text)
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
                    }
                    
                }
                index++;
            }
            if (lblBalance.Text == "1000000")
            {
                Congratulations CongratulationsForm = new Congratulations();
                CongratulationsForm.Show();
            }
            lblBalance.Text = string.Format("£{0:#.00}", Convert.ToDecimal(balance));

            if (txtTransaction.Text == "resetmenow!")
            {
                this.Close();
                Clipboard.Clear();
                Form login = Application.OpenForms["login"];
                login.Show();
            }
        }
    }
}