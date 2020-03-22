using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amountOfCredit;
            double percent;
            double term;
            double monthPayment;
            double amountOfPayment;

            amountOfCredit = Convert.ToDouble(textBox1.Text);
            percent = Convert.ToDouble(textBox2.Text);
            term = Convert.ToDouble(textBox5.Text);
            monthPayment = Convert.ToDouble(textBox3.Text);
            amountOfPayment = Convert.ToDouble(textBox4.Text);

            CreditCalc Credit = new CreditCalc(amountOfCredit, percent, term, monthPayment, amountOfPayment);
            switch (CreditCalc.taskType)
            {
                case 1:
                    textBox1.Text = Math.Round(Credit.AmountOfCredit(), 2).ToString();
                    textBox4.Text = Math.Round(Credit.AmountOfPayment(), 2).ToString();
                    break;
                case 2:
                    textBox4.Text = Math.Round(Credit.AmountOfPayment(), 2).ToString();
                    textBox2.Text = Math.Round(Credit.GetPercent(), 2).ToString();
                    break;
                case 3:
                    textBox4.Text = Math.Round(Credit.AmountOfPaymentTerm(), 0).ToString();
                    textBox5.Text = Math.Round(Credit.GetTerm(), 0).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
