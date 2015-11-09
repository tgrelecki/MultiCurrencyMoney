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
    }
}
