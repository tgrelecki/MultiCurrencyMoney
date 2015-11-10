using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiCurrencyMoney.Test
{
    [TestClass]
    public class CurrencyTests
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
            Assert.AreEqual(new Franc(5), new Franc(5));
            Assert.AreNotEqual(new Franc(5), new Franc(6));
            Assert.AreNotEqual(new Franc(5), Money.Dollar(5));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }
    }
}
