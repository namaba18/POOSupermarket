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
                $"Products...: {Products} " +
                $"Discount...: {Discount:C2},18" +
                $"Value......: {ValueToPay():C2},18";
        }

    }
}
