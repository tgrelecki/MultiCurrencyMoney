using System;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int value)
        {
            Amount = value;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
