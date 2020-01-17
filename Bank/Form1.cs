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
    public partial class Form1 : Form
    {
        
        public Form1()
        {            
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int[] accountNumber = { 0, 2, 5, 8, 7, 4 };

            int number1 = Convert.ToInt32(Num1.Value);
            int number2 = Convert.ToInt32(Num2.Value);
            int number3 = Convert.ToInt32(Num3.Value);
            int number4 = Convert.ToInt32(Num4.Value);
            int number5 = Convert.ToInt32(Num5.Value);
            int number6 = Convert.ToInt32(Num6.Value);

            if (number1 == accountNumber[0] && number2 == accountNumber[1] && number3 == accountNumber[2] && number4 == accountNumber[3] && number5 == accountNumber[4] && number6 == accountNumber[5]) {
                label1.Text = "Worked!";
            }
            List<int> numbers = new List<int>();
            foreach (char number in txtAccountNumber.Text.ToCharArray())
            {
                Console.WriteLine(number);
                int numberint = (int)Char.GetNumericValue(number);
                numbers.Add(numberint);
            }
            
            if (numbers[0] == accountNumber[0] && numbers[1] == accountNumber[1] && numbers[2] == accountNumber[2] && numbers[3] == accountNumber[3] && numbers[4] == accountNumber[4] && numbers[5] == accountNumber[5])
            {
                label2.Text = "Worked!!!";
            }
        }

    }
}
