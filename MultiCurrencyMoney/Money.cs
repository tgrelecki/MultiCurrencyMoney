namespace MultiCurrencyMoney
{
    public abstract class Money
    {
        internal int Amount;

        public abstract Money Times(int multiplier);

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount
                && this.GetType() == obj.GetType();
        }
    }
}
