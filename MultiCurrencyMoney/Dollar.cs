using System;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
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
