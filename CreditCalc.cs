using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalc
{
    class CreditCalc
    {
        public static int taskType { get; set; }
        private double amount_Of_Credit;
        private double percent;
        private double term;
        private double month_Payment;
        private double amount_Of_Payment;
        
        public CreditCalc()
        {
            amount_Of_Credit = 0;
            percent = 0;
            term = 0;
            month_Payment = 0;
            amount_Of_Payment = 0;
        }

        public CreditCalc(double amount_Of_Credit_, double percent_, double term_, double month_Payment_, double amount_Of_Payment_)
        {
            amount_Of_Credit = amount_Of_Credit_;
            percent = percent_;
            term = term_;
            month_Payment = month_Payment_;
            amount_Of_Payment = amount_Of_Payment_;
        }

        public double AmountOfCredit()
        {
            amount_Of_Credit = ((month_Payment * term) / Math.Pow((1 + percent / 100), term));
            return amount_Of_Credit;
        }

        public double AmountOfPayment()
        {
            amount_Of_Payment = month_Payment * term;
            return amount_Of_Payment;
        }

        public double GetPercent()
        {
            percent = (Math.Pow(AmountOfPayment() / amount_Of_Credit, 1 / term) - 1) * 100;
            return percent;
        }

        private void ChangeTerm(int term_)
        {
            term = term_;
        }

        public double AmountOfPaymentTerm()
        {
            amount_Of_Payment = month_Payment * term + amount_Of_Credit;
            return amount_Of_Payment;
        }

        public double GetTerm()
        {
            ChangeTerm(1);
            term = amount_Of_Payment / month_Payment;
            return term;
        }
    }
}
