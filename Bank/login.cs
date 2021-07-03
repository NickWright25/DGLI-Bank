using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Bank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void login_Resize(object sender, EventArgs e)
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = File.ReadAllText($@"{Directory.GetCurrentDirectory()}\852-897-2.txt");
            if (txtPassword.Text == password)
            {
                this.Hide();
                bool value = false;
                FormCollection forms = Application.OpenForms;
                foreach (Form form in forms)
                {
                    if (form.Name == "transactions")
                    {
                        value = true;
                        form.Show();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (value == false)
                {
                    Transactions transactionsForm = new Transactions();
                    transactionsForm.Closed += (s, args) => this.Close();
                    transactionsForm.Show();
                }
            } else
            {
                IncorrectPassword IncorrectPasswordForm = new IncorrectPassword();
                IncorrectPasswordForm.Show();
            }
            txtPassword.Text = "";
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}