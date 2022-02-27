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
                total += p.ValueToPay();
            }
            return total - (total * (decimal)Discount);
        }

        public override string ToString()
        {
            string cadena = Products.First().Description;
            for (int i = 1; i < Products.Count-1; i++)
            {
                cadena += $", {Products.ElementAt(i).Description}";
            }

            return $"{$"{Id}",7} {$"{Description}"}" +
                $"\n\tProducts...: {$"{cadena}"}" +
                $"\n\tDiscount...: {$"{Discount:P2}",20}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",18}";
        }

    }
}
