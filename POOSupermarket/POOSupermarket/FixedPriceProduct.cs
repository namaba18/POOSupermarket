namespace POOSupermarket
{
    public class FixedPriceProduct : Product
    {
        public override string ToString()
        {
            return $"Value......: {$"{ValueToPay():C2}",18}";
        }

        public override decimal ValueToPay()
        {
            return Price * (decimal)Tax;
        }
    }
}
