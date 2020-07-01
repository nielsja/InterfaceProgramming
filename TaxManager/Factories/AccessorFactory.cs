using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManagerApp.Accessors
{
    public class AccessorFactory : IAccessorFactory
    {
        public T CreateAccessor<T>(string subType = "") where T : class
        {
            if (typeof(T) == typeof(ITaxRate))
            {
                switch (subType)
                {
                    case "US":
                        return new TaxRateUS() as T;
                    case "UK":
                        return new TaxRateUK() as T;
                }
            }

            if (typeof(T) == typeof(ISubtotal))
            {
                return new Subtotal() as T;
            }

            throw new ArgumentException("Invalid Accessor Type");
        }
    }
}
