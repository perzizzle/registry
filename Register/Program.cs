using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Transaction transaction = new Transaction();
            transaction = getInfo();

            Console.WriteLine("Change dollars:");
            Console.WriteLine(transaction.changeDollars);
            Console.WriteLine("Change cents:");
            Console.WriteLine(transaction.changeCents);

            //output change

            string s = Console.ReadLine();
        }

        public static Transaction getInfo()
        {
            Product product = new Product();
            Transaction transaction = new Transaction();
            bool validated = false;

            while (!validated)
            {
                validated = true;
                Console.WriteLine("How many dollars is your purchase?");
                string sProductDollars = Console.ReadLine();
                Console.WriteLine("How many cents is your purchase?");
                string sProductCents = Console.ReadLine();

                Console.WriteLine("How many dollars did you pay");
                string sPaymentDollars = Console.ReadLine();
                Console.WriteLine("How many cents did you pay?");
                string sPaymentCents = Console.ReadLine();

                product.dollar = validate(sProductDollars);
                product.cents = validate(sProductCents);
                transaction.paymentDollars = validate(sPaymentDollars);
                transaction.paymentCents = validate(sPaymentCents);

                int totalPayment = transaction.paymentDollars * 100 + transaction.paymentCents;
                int totalProduct = product.dollar * 100 + product.cents;
                if ( totalProduct > totalPayment )
                {
                    Console.WriteLine("Insufficeint payment");
                    validated = false;
                }
                transaction.product = product;
                int totalChange = totalPayment - totalProduct;
                transaction.changeDollars = totalChange / 100;
                totalChange = totalChange - transaction.changeDollars * 100;
                transaction.changeCents = totalChange;

                //Calculate specific change
               
            }



            return transaction;

        }

        public static int validate(string input)
        {
            int value;
            Int32.TryParse(input, out value);
            // fail validation if not integer
            return value;
        }

        public class Transaction
        {
            public int paymentDollars;
            public int paymentCents;
            public Product product;
            public int changeDollars;
            public int changeCents;
        }

        public class Product
        {
           public int dollar { get; set; }
           public int cents { get; set; }

        }
    }
}
