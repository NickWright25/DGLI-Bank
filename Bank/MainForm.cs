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
    public partial class MainForm : Form
    {
        private login _login = new login();
        private transactions _transaction = new transactions();
        protected void ShowForm()
        {
            _login.Show();
            _transaction.Show();
        }
        protected void HideForm()
        {
            _login.Hide();
            _transaction.Show();
        }
    }
}
