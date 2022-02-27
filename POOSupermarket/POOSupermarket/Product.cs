namespace POOSupermarket
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public override string ToString()
        {
            return $"{$"{Id}",7} {Description}" +
                $"\n\tPrice......: {$"{Price:C2}",18}" +
                $"\n\tTax........: {$"{Tax:P2}",20}";
        }

        public abstract decimal ValueToPay(); 
                    

    }
}
