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
    public partial class transactions : Form
    {
        public transactions()
        {
            InitializeComponent();
        }
        public int balance = 0;
        public int transactionNumber = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int index = 0;
            string[] transactions = System.IO.File.ReadAllLines(@"C:\Users\Nick\Documents\Don't Get Locked In\transactions.txt");
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
                
            }
        }

        private void transactions_Load(object sender, EventArgs e)
        {
        }
    }
}