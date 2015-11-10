namespace MultiCurrencyMoney
{
    public abstract class Money
    {
        public string Currency { get; set; }

        internal int Amount { get; set; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public abstract Money Times(int multiplier);

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount
                && this.GetType() == obj.GetType();
        }
    }
}
