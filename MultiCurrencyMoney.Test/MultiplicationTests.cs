using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiCurrencyMoney.Test
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            five.times(2);

            Assert.AreEqual(10, five.Amount);
        }


    }
}
