namespace MultiCurrencyMoney
{
    public class Money
    {
        internal int Amount;

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount
                && this.GetType() == obj.GetType();
        }
    }
}
