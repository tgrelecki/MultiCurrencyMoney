namespace MultiCurrencyMoney
{
    public class Money
    {
        public string Currency { get; set; }

        internal int Amount { get; set; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount
                && Currency == money.Currency;
        }
    }
}
