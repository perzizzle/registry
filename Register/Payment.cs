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

        public Payment getPayment()
        {
            Payment payment = new Payment();
            int paymentDollars = 0;
            int paymentCents = 0;

            Console.WriteLine("How many dollars did you pay");
            string sPaymentDollars = Console.ReadLine();
            Console.WriteLine("How many cents did you pay?");
            string sPaymentCents = Console.ReadLine();

            if (!int.TryParse(sPaymentDollars, out paymentDollars)) throw new ArgumentException("Payment dollars must be an integer");
            if (!int.TryParse(sPaymentCents, out paymentCents)) throw new ArgumentException("Payment cents must be an integer");

            payment.dollar = paymentDollars;
            payment.cent = paymentCents;

            return payment;
        }
    }


}
