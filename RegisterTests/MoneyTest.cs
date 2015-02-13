using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register;

namespace RegisterTests
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void MoneyValidTest()
        {
            string sDollar = "10";
            string sCent = "1";
            int amount = 1001;

            Money actual = new Money(sDollar, sCent);

            Assert.AreEqual(amount, actual.amount);
        }

        [ExpectedException(typeof(FormatException), "Cannot convert to int")]
        [TestMethod]
        public void MoneyInValidTest()
        {
            string sDollar = "asdfasdf";
            string sCent = "1";
            int amount = 1001;

            Money actual = new Money(sDollar, sCent);

            //Assert.AreEqual(amount, actual.amount);
        }
    }
}
