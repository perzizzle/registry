using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{

    public class Transaction
    {
        public Payment payment { get; set; }
        public Product product { get; set; }
        public Change change { get; set; }

        public Transaction processTransaction()
        {
            Transaction transaction = new Transaction();
            Product product = new Product();
            Payment payment = new Payment();
            Change change = new Change();

            string sProductDollar = product.getProductDollar();
            string sProductCent = product.getProductCent();

            string sPaymentDollar = payment.getPaymentDollar();
            string sPaymentCent = payment.getPaymentCent();

            transaction.payment = payment.buildPayment(sPaymentDollar, sPaymentCent);
            transaction.product = product.buildProduct(sProductDollar, sProductCent);
            transaction.change = change.calculateChange(transaction.product, transaction.payment);

            return transaction;
        }
    }
}
