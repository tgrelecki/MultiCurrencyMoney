using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiCurrencyMoney.Test
{
    [TestClass]
    public class MultiCurrencyMoneyTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.AreEqual(Money.Dollar(5), Money.Dollar(5));
            Assert.AreNotEqual(Money.Dollar(5), Money.Dollar(6));
            Assert.AreEqual(Money.Franc(5), Money.Franc(5));
            Assert.AreNotEqual(Money.Franc(5), Money.Franc(6));
            Assert.AreNotEqual(Money.Franc(5), Money.Dollar(5));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }
        
        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency);
            Assert.AreEqual("CHF", Money.Franc(1).Currency);
        }
    }
}
