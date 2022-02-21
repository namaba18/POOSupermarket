namespace POOSupermarket
{
    public abstract class Product
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public override string ToString()
        {
            return $"{$"{Id}",6} {Description}" +
                $"\nPrice......: {$"{Price:C2}",18}" +
                $"\nTax........: {$"{Tax:P2}",18}";
        }

        public abstract decimal ValueToPay(); 
                    

    }
}
