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

        public Dollar times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
