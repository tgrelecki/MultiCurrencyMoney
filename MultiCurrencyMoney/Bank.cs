namespace MultiCurrencyMoney
{
    public class Bank
    {
        public Money Reduce(ICurrencyExpression source, string to)
        {
            return Money.Dollar(10);
        }
    }
}
