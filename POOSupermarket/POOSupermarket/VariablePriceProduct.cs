namespace POOSupermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return (decimal)Quantity * Price + (decimal)Quantity * Price * (decimal)Tax;

        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement: {$"{Measurement}", 18}" +
                $"\n\tQuantity...: {$"{Quantity}", 18}" +
                $"\n\tValue......: {$"{ValueToPay():C2}", 18}";

        }
    }
}
