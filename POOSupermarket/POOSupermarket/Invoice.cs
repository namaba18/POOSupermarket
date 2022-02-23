namespace POOSupermarket
{
    public class Invoice : IPay
    {
        private List<Product> _product;

        public void Addproduct(Product product)
        {
            _product.Add(product);
        }

        //public void Invoice()

        public override string ToString()
        {
            foreach (Product product in _product)
            {
                return product.ToString();
            }

            return " ";
        }

        public decimal ValueToPay()
        {
            decimal prev = 0, total=0;
            foreach (Product product in _product)
            {
                prev = product.ValueToPay();
                total = product.ValueToPay() + prev;
            }
            
            return total ;
        }


    }
}
