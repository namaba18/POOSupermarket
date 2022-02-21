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
                $"Measurement: {$"{Measurement}, 18"}" +
                $"Quantity...: {$"{Quantity}, 18"}" +
                $"Value......: {$"{ValueToPay()}:C2, 18"}";

        }
    }
}
