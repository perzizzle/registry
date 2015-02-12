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

            transaction.product = product.getProduct();
            transaction.payment = payment.getPayment();
            transaction.change = change.calculateChange(transaction.product, transaction.payment);

            return transaction;
        }
    }

}
