using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register;

namespace RegisterTests
{
    [TestClass]
    public class PaymentTests
    {
        [TestMethod]
        public void GetPaymentTestValid()
        {
            //arrange
            Payment actual = new Payment();
            Payment expected = new Payment();

            string sPaymentDollars = "10";
            string sPaymentCents = "35";
            expected.dollar = 10;
            expected.cent = 35;

            //act
            actual = actual.buildPayment(sPaymentDollars, sPaymentCents);

            //asssert
            Assert.AreEqual(expected.dollar, actual.dollar, "failed to build dollar");
            Assert.AreEqual(expected.cent, actual.cent, "failed to build cent");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Payment dollars must be an integer")]
        public void GetPaymentTestInValid()
        {
            //arrange
            Payment actual = new Payment();
            Payment expected = new Payment();

            string sPaymentDollars = "asdfadsf";
            string sPaymentCents = "35";
            expected.dollar = 10;
            expected.cent = 35;

            //act
            actual = actual.buildPayment(sPaymentDollars, sPaymentCents);           
        }
    }
}
