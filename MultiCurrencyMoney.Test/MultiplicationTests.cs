using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiCurrencyMoney.Test
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.times(2));
            Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.AreEqual(new Dollar(5), new Dollar(5));
            Assert.AreNotEqual(new Dollar(5), new Dollar(6));
        }
    }
}
