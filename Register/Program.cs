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
            try
            { 
                Console.WriteLine("How many dollars is your purchase?");
                string sProductDollars = Console.ReadLine();

                Console.WriteLine("How many cents is your purchase?");
                string sProductCents = Console.ReadLine();

                Money product = new Money(sProductDollars, sProductCents);

                Console.WriteLine("How many dollars did you pay");
                string sPaymentDollar = Console.ReadLine();

                Console.WriteLine("How many cents did you pay?");
                string sPaymentCent = Console.ReadLine();

                Money payment = new Money(sPaymentDollar, sPaymentCent);
                Change change = new Change(product, payment);

                Transaction transaction = new Transaction(product, payment, change);

                Console.WriteLine("Total Change:");
                Console.WriteLine(transaction.change.totalChangeCents);

                Console.WriteLine("Change hundred:");
                Console.WriteLine(transaction.change.hundred);

                Console.WriteLine("Change twenties:");
                Console.WriteLine(transaction.change.twenty);

                Console.WriteLine("Change ten:");
                Console.WriteLine(transaction.change.ten);

                Console.WriteLine("Change five:");
                Console.WriteLine(transaction.change.five);

                Console.WriteLine("Change ones:");
                Console.WriteLine(transaction.change.one);

                Console.WriteLine("Change quarter:");
                Console.WriteLine(transaction.change.quarter);

                Console.WriteLine("Change dime:");
                Console.WriteLine(transaction.change.dime);

                Console.WriteLine("Change nickel:");
                Console.WriteLine(transaction.change.nickel);

                Console.WriteLine("Change penny:");
                Console.WriteLine(transaction.change.penny);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string s = Console.ReadLine();
            }

        }

    }
}
