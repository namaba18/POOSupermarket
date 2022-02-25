namespace POOSupermarket
{
    public class Invoice : IPay
    {
        private List<Product> _product = new List<Product>();

        public Invoice()
        {
        }

        public void AddProduct(Product product)
        {
            _product.Add(product);
        }

        public override string ToString()
        {
            string cadena = "";
            foreach (Product p in _product)
            {
                cadena += $"\n{p.ToString()}";
            }

            return $"RECEIPT" +
                    $"\n-------------------------------------------------" +
                    $"\n{cadena}" +
                    $"\n                          =============" +
                    $"\n                     {$"{ValueToPay():C2}",18}";
        }

        public decimal ValueToPay()
        {
            decimal prev = 0, total=0;
            foreach (Product product in _product)
            {
                total += product.ValueToPay();
            }
            
            return total ;
        }


    }
}
