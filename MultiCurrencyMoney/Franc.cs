using System;

namespace MultiCurrencyMoney
{
    public class Franc
    {
        private int Amount;

        public Franc(int value)
        {
            Amount = value;
        }

        public Franc times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Franc)obj;
            return Amount == dollar.Amount;
        }
    }
}
