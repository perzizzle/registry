using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register;

namespace RegisterTests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]
        public void CalculateChangeTestValid()
        {
            Product product = new Product();
            Payment payment = new Payment();
            Change actual = new Change();
            Change expected = new Change();

            product.dollar = 10;
            product.cent = 1;

            payment.dollar = 99;
            payment.cent = 1;

            expected.totalChangeCents = 8900;
            expected.hundred = 0;
            expected.twenty = 4;
            expected.ten = 0;
            expected.five = 1;
            expected.one = 3;

            expected.quarter = 0;
            expected.dime = 0;
            expected.nickel = 0;
            expected.penny = 0;

            actual = actual.calculateChange(product, payment);

            Assert.AreEqual(expected, actual);
            
        }
    }
}
