using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register;

namespace RegisterTests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]
        public void ChangeTestValid()
        {
            Money product = new Money(sDollar:"1", sCent:"1");
            Money payment = new Money(sDollar:"137",sCent:"42");
            Change expected = new Change(totalChangeCents:13641, hundred:1, twenty:1, ten:1, five:1, one:1, quarter:1, dime:1, nickel:1, penny:1);

            Change actual = new Change(product, payment);
            
            //For some reason comparing objects fail
            Assert.AreEqual(expected.totalChangeCents, actual.totalChangeCents);
            Assert.AreEqual(expected.hundred, actual.hundred);
            Assert.AreEqual(expected.twenty, actual.twenty);
            Assert.AreEqual(expected.ten, actual.ten);
            Assert.AreEqual(expected.five, actual.five);
            Assert.AreEqual(expected.one, actual.one);
            Assert.AreEqual(expected.quarter, actual.quarter);
            Assert.AreEqual(expected.dime, actual.dime);
            Assert.AreEqual(expected.nickel, actual.nickel);
            Assert.AreEqual(expected.penny, actual.penny);
            
        }

        [ExpectedException(typeof(ArgumentException), "Payment must be greater than product cost")]
        [TestMethod]
        public void ChangeInValidUnderPayTest()
        {
            Money product = new Money(sDollar: "11111", sCent: "1");
            Money payment = new Money(sDollar: "137", sCent: "42");

            Change actual = new Change(product, payment);
        }

        [ExpectedException(typeof(ArgumentException), "Payment and product must be greater than 0")]
        [TestMethod]
        public void ChangeInValidZeroTest()
        {
            Money product = new Money(sDollar: "0", sCent: "0");
            Money payment = new Money(sDollar: "0", sCent: "0");

            Change actual = new Change(product, payment);
        }

        
    }
}
