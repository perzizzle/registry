using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register;

namespace RegisterTests
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void TransactionTestValid()
        {
            Money product = new Money(101);
            Money payment = new Money(13742);
            Change change = new Change(product, payment);

            Transaction expected = new Transaction(iProduct:101, iPayment:13742, totalChangeCents: 13641, hundred: 1, twenty: 1, ten: 1, five: 1, one: 1, quarter: 1, dime: 1, nickel: 1, penny: 1);

            Transaction actual = new Transaction(product, payment, change);

            //For some reason comparing objects fail
            //This should succeed
            Assert.AreEqual(expected, actual);
        }
    }
}
