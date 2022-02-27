using System.Linq;

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
                return total-(total*(decimal)Discount);
        }

        public override string ToString()
        {
            string cadena = "";
            foreach (Product p in Products)
            {
                return Product.ToString();
            }
            return $"{$"{Id}",7} {$"{Description}"}" +
                $"\n\tProducts...: {$"{cadena}"}" +
                $"\n\tDiscount...: {$"{Discount:P2}",18}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",18}";
        }

    }
}
