using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{

    public class Transaction
    {
        //public Payment payment { get; set; }
        public Money product { get; set; }
        public Money payment { get; set; }
        public Change change { get; set; }

        public Transaction (Money product, Money payment, Change change)
        {
            this.product = product;
            this.payment = payment;
            this.change = change;
        }

        public Transaction(int iProduct, int iPayment, int totalChangeCents, int hundred, int twenty, int ten, int five, int one, int quarter, int dime, int nickel, int penny)
        {
            Money product = new Money(iProduct);
            Money payment = new Money(iPayment);
            this.product = product;
            this.payment = payment;
            this.change.totalChangeCents = totalChangeCents;
            this.change.hundred = hundred;
            this.change.twenty = twenty;
            this.change.ten = ten;
            this.change.five = five;
            this.change.one = one;
            this.change.quarter = quarter;
            this.change.dime = dime;
            this.change.nickel = nickel;
            this.change.penny = penny;
        }
    }
}
