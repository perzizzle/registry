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

        public Change (Money product, Money payment)
        {
            int totalPayment = payment.amount;
            int totalProduct = product.amount;

            if (totalProduct > totalPayment)
            {
                throw new ArgumentException("Payment must be greater than product cost");
            }
            else if (totalProduct <= 0 || totalPayment <= 0)
            {
                throw new ArgumentException("Payment and product must be greater than 0");
            }

            int totalChangeCents = totalPayment - totalProduct;
            this.totalChangeCents = totalChangeCents;

            int dollarCount = totalChangeCents / 100;
            int centCount = totalChangeCents - dollarCount * 100;

            if (dollarCount >= 100)
            {
                this.hundred = dollarCount / 100;
                dollarCount -= this.hundred * 100;
            }
            if (dollarCount >= 20)
            {
                this.twenty = dollarCount / 20;
                dollarCount -= this.twenty * 20;
            }
            if (dollarCount >= 10)
            {
                this.ten = dollarCount / 10;
                dollarCount -= this.ten * 10;
            }
            if (dollarCount >= 5)
            {
                this.five = dollarCount / 5;
                dollarCount -= this.five * 5;
            }
            if (dollarCount >= 1)
            {
                this.one = dollarCount / 1;
                dollarCount -= this.one * 1;
            }

            if (centCount >= 25)
            {
                this.quarter = centCount / 25;
                centCount -= this.quarter * 25;
            }
            if (centCount >= 10)
            {
                this.dime = centCount / 10;
                centCount -= this.dime * 10;
            }
            if (centCount >= 5)
            {
                this.nickel = centCount / 5;
                centCount -= this.nickel * 5;
            }
            if (centCount >= 1)
            {
                this.penny = centCount / 1;
                centCount -= this.penny * 1;
            }
        }

        public Change(int totalChangeCents, int hundred, int twenty, int ten, int five, int one, int quarter, int dime, int nickel, int penny )
        {

            this.totalChangeCents = totalChangeCents;
            this.hundred = hundred;
            this.twenty = twenty;
            this.ten = ten;
            this.five = five;
            this.one = one;
            this.quarter = quarter;
            this.dime = dime;
            this.nickel = nickel;
            this.penny = penny;
        }
    }
}
