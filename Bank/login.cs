using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = System.IO.File.ReadAllText(@"C:\Users\DGLI\Documents\Bank\password.txt");
            if (txtPassword.Text == password)
            {
                transactions transactionsForm = new transactions();
                transactionsForm.Show();
                this.Hide();
            } else
            {
                IncorrectPassword IncorrectPasswordForm = new IncorrectPassword();
                IncorrectPasswordForm.Show();
            }
            txtPassword.Text = "";
        }
    }
}
