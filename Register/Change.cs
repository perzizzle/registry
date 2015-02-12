using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class Change
    {
        
        public int totalChangeCents { get; set; }
        public int hundred { get; set; }
        public int twenty { get; set; }
        public int ten { get; set; }
        public int five { get; set; }
        public int one { get; set; }

        public int quarter { get; set; }
        public int dime { get; set; }
        public int nickel { get; set; }
        public int penny { get; set; }

        public Change calculateChange(Product product, Payment payment)
        {
            Change change = new Change();
            int totalPayment = payment.dollar * 100 + payment.cent;
            int totalProduct = product.dollar * 100 + product.cent;

            if (totalProduct > totalPayment)
            {
                throw new ArgumentException("Payment must be greater than product cost");
            }
            else if (totalProduct <= 0 || totalPayment <= 0)
            {
                throw new ArgumentException("Payment and product must be greater than 0");
            }

            int totalChangeCents = totalPayment - totalProduct;
            change.totalChangeCents = totalChangeCents;

            int dollarCount = totalChangeCents / 100;
            int centCount = totalChangeCents - dollarCount * 100;

            if (dollarCount >= 100)
            {
                change.hundred = dollarCount / 100;
                dollarCount -= change.hundred * 100;
            }
            if (dollarCount >= 20)
            {
                change.twenty = dollarCount / 20;
                dollarCount -= change.twenty * 20;
            }
            if (dollarCount >= 10)
            {
                change.ten = dollarCount / 10;
                dollarCount -= change.ten * 10;
            }
            if (dollarCount >= 5)
            {
                change.five = dollarCount / 5;
                dollarCount -= change.five * 5;
            }
            if (dollarCount >= 1)
            {
                change.one = dollarCount / 1;
                dollarCount -= change.one * 1;
            }
            return change;
        }

        public void displayChange(Transaction transaction)
        {
            Console.WriteLine("Total Change:");
            Console.WriteLine(transaction.change.totalChangeCents);

            Console.WriteLine("Change hundred:");
            Console.WriteLine(transaction.change.hundred);

            Console.WriteLine("Change twenties:");
            Console.WriteLine(transaction.change.twenty);

            Console.WriteLine("Change five:");
            Console.WriteLine(transaction.change.five);

            Console.WriteLine("Change ones:");
            Console.WriteLine(transaction.change.one);
        }
    }
}
