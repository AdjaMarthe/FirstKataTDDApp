using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstKataTDDApp;

namespace FirstKataTDDApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInstanciateAccountBalance()
        {
            var account = new Account(0);
            Assert.AreEqual(account.Balance, 0);
        }

        [TestMethod]
        public void TestAccountDeposit_Positive_Value()
        {
            var account = new Account(100);
            account.Deposit(10);
            Assert.AreEqual(account.Amount, "+10");
            Assert.AreEqual(account.Balance, 110);
        }

        [TestMethod]
        public void TestAccountDeposit_Negative_Value()
        {
            var account = new Account(100);
            account.Deposit(-10);
            Assert.AreEqual(account.Balance, 100);
        }

        [TestMethod]
        public void TestAccountDeposit0()
        {
            var account = new Account(100);
            account.Deposit(0);
            Assert.AreEqual(account.Balance, 100);
        }


        [TestMethod]
        public void TestAccountWithdraw0()
        {
            var account = new Account(100);
            account.Withdraw(0);
            Assert.AreEqual(account.Balance, 100);
        }

        [TestMethod]
        public void TestAccountWithdraw_Positive_Value()
        {
            var account = new Account(100);
            account.Withdraw(10);
            Assert.AreEqual(account.Amount, "-10");
            Assert.AreEqual(account.Balance, 90);
        }

        [TestMethod]
        public void TestAccountWithdraw_Negative_Value()
        {
            var account = new Account(100);
            account.Withdraw(-10);
            Assert.AreEqual(account.Balance, 100);
        }

    }
}
