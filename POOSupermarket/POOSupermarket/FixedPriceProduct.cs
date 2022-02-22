﻿namespace POOSupermarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + Price * (decimal)Tax;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",18}";
        }


    }
}
