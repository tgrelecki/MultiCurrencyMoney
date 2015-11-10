namespace MultiCurrencyMoney
{
    public class Franc : Money
    {

        public Franc(int value)
        {
            Amount = value;
        }

        public Franc times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
