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

        public Product getProduct()
        {
            Product product = new Product();
            int productDollars = 0;
            int productCents = 0;

            Console.WriteLine("How many dollars is your purchase?");
            string sProductDollars = Console.ReadLine();
            Console.WriteLine("How many cents is your purchase?");
            string sProductCents = Console.ReadLine();

            if (!int.TryParse(sProductDollars, out productDollars)) throw new ArgumentException("Product dollars must be an integer");
            if (!int.TryParse(sProductCents, out productCents)) throw new ArgumentException("Product cents must be an integer");

            product.dollar = productDollars;
            product.cent = productCents;

            return product;
        }

    }
}
