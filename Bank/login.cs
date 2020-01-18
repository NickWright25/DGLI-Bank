using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string password = System.IO.File.ReadAllText(@"C:\Users\Nick\Documents\Don't Get Locked In\password.txt");
            if (txtPassword.Text == password)
            {
                /*transactions transactionsForm = new transactions();
                transactionsForm.Show();
                this.Hide();*/
                FormProvider.transaction.Show();
            } else
            {
                IncorrectPassword IncorrectPasswordForm = new IncorrectPassword();
                IncorrectPasswordForm.Show();
            }
        }
    }
}
