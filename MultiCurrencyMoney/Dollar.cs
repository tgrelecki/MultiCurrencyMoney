namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int value, string currency) :
            base(value, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }
    }
}
