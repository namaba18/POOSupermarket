namespace POOSupermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal total = 0;
            foreach (Product p in Products)
            {
                total = Product
            }
                return 78000M;
        }

        public override string ToString()
        {
            foreach (Product p in Products)
            {
                return Product.ToString();
            }
            return " ";
        }

    }
}
