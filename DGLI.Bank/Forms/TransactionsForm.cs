using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGLI.Bank.Forms
{
	public partial class TransactionsForm : Form
	{
        private readonly IServiceProvider _serviceProvider;
        private readonly Settings _options;
        private int balance = 0;
        private int transactionNumber = 0;
        public TransactionsForm(IServiceProvider serviceProvider, IOptions<Settings> options)
        {
            _serviceProvider = serviceProvider;
            _options = options.Value;
            InitializeComponent();
        }

        private static void PlaySound(string file)
        {
            var sound = new SoundPlayer(file);
            sound.Play();
        }

        //Function to check whether transaction number is valid and display corresponding amount
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var transaction = _options.TransactionValues.SingleOrDefault(t => t.Key.ToLower() == txtTransaction.Text.ToLower());

            if (transaction.Key != null && !listTransactions.Rows.Cast<DataGridViewRow>().Any(row => transaction.Key == row.Cells[1].Value.ToString())) 
            {
                AddTransaction(transaction);
            };

            if (lblBalance.Text == "1000000") WinGame();

            lblBalance.Text = string.Format("£{0:#.00}", Convert.ToDecimal(balance));

            if (txtTransaction.Text == "resetmenow!") ResetGame();

            txtTransaction.Text = "";
        }

        private void AddTransaction(KeyValuePair<string, int> transaction)
		{
            transactionNumber++;
            listTransactions.Rows.Add(transactionNumber, transaction.Key, transaction.Value);
            balance += transaction.Value;
            lblBalance.Text = balance.ToString();
            if (File.Exists(_options.TransactionSoundFilePath))
            {
                PlaySound(_options.TransactionSoundFilePath);
            }
        }

        private void WinGame()
		{
            var CongratulationsForm = (CongratulationsForm)_serviceProvider.GetService(typeof(CongratulationsForm));
            CongratulationsForm.Show();

            var file = _options.CongratulationsSoundFilePath;
            if (File.Exists(file))
            {
                PlaySound(file);
            }
        }

        private void ResetGame()
		{
            if (CheckFormOpen("LoginForm"))
            {
                var loginForm = Application.OpenForms["LoginForm"];
                loginForm.Show();
                Cleanup();
                this.Hide();
            }
            else
            {
                var login = (LoginForm)_serviceProvider.GetService(typeof(LoginForm));
                login.Show();
            }
        }

		private static bool CheckFormOpen(string formName)
        {
            return Application.OpenForms.Cast<Form>().Any(form => form.Name == formName);
        }

        private void Cleanup()
        {
            Clipboard.Clear();
            listTransactions.Rows.Clear();
            lblBalance.Text = "";
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
    }
}
