using System;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int value)
        {
            Amount = value;
        }

        public void times(int value)
        {
            Amount *= value;
        }
    }
}
