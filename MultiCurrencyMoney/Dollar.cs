using System;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        private int Amount;

        public Dollar(int value)
        {
            Amount = value;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Dollar)obj;
            return Amount == dollar.Amount;
        }
    }
}
