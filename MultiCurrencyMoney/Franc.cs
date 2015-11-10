namespace MultiCurrencyMoney
{
    public class Franc : Money
    {

        public Franc(int value)
        {
            Amount = value;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
