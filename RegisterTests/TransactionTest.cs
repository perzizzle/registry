using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register;

namespace RegisterTests
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void ProcessTransactionTestValid()
        {
            Transaction transaction = new Transaction();

            transaction.processTransaction();
        }
    }
}
