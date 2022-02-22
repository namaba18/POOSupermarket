namespace POOSupermarket
{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            return 78000M;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tProducts...: {Products} " +
                $"\n\tDiscount...: {$"{Discount:P2}",18}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",18}";
        }

    }
}
