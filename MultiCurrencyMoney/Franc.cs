﻿namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        public Franc(int value, string currency) :
            base(value, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}
