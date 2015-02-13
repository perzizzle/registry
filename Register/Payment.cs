using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class Payment
    {
        public int dollar { get; set; }
        public int cent { get; set; }

        public Payment buildPayment(string sPaymentDollar, string sPaymentCent)
        {
            Payment payment = new Payment();
            int paymentDollar = 0;
            int paymentCent = 0;

            if (!int.TryParse(sPaymentDollar, out paymentDollar)) throw new ArgumentException("Payment dollars must be an integer");
            if (!int.TryParse(sPaymentCent, out paymentCent)) throw new ArgumentException("Payment cents must be an integer");

            payment.dollar = paymentDollar;
            payment.cent = paymentCent;

            return payment;
        }

        public string getPaymentDollar()
        {
            Console.WriteLine("How many dollars did you pay");
            string sPaymentDollar = Console.ReadLine();
            return sPaymentDollar;
        }

        public string getPaymentCent()
        {
            Console.WriteLine("How many cents did you pay?");
            string sPaymentCent = Console.ReadLine();
            return sPaymentCent;
        }

    }


}
