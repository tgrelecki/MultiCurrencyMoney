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
            Dollar product = five.times(2);
            
            Assert.AreEqual(10, product.Amount);

            product = five.times(3);
            Assert.AreEqual(15, product.Amount);
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.AreEqual(new Dollar(5), new Dollar(5));
            Assert.AreNotEqual(new Dollar(5), new Dollar(6));
        }
    }
}
