using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class Product
    {
        public int dollar { get; set; }
        public int cent { get; set; }

        public Product buildProduct(string sProductDollar, string sProductCent)
        {
            Product product = new Product();
            int productDollar = 0;
            int productCent = 0;

            if (!int.TryParse(sProductDollar, out productDollar)) throw new ArgumentException("Product dollars must be an integer");
            if (!int.TryParse(sProductCent, out productCent)) throw new ArgumentException("Product cents must be an integer");

            product.dollar = productDollar;
            product.cent = productCent;

            return product;
        }

        public string getProductDollar()
        {
            Console.WriteLine("How many dollars is your purchase?");
            string sProductDollars = Console.ReadLine();
            return sProductDollars;
        }

        public string getProductCent()
        {
            Console.WriteLine("How many cents is your purchase?");
            string sProductCents = Console.ReadLine();
            return sProductCents;
        }

    }
}
