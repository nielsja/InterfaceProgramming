using System;
using System.Collections.Generic;
using System.Text;
using TaxManagerApp.Accessors;

namespace TaxManagerTests
{
    public class MockAccessorFactory : IAccessorFactory
    {
        public ISubtotal MockSubtotal { get; set; }
        public ITaxRate MockTaxRate { get; set; }

        public T CreateAccessor<T>(string subType = "") where T : class
        {
            if (typeof(T) == typeof(ISubtotal))
            {
                return MockSubtotal as T;
            }
            if (typeof(T) == typeof(ITaxRate))
            {
                return MockTaxRate as T;
            }

            throw new ArgumentException("Invalid Accessor Type");
        }
    }

    public class MockSubtotal : ISubtotal
    {
        public decimal subtotal { get; set; }

        public decimal GetSubtotal()
        {
            return subtotal;
        }
    }

    public class MockTaxRate : ITaxRate
    {
        public decimal taxRate { get; set; }
        public decimal taxAmount { get; set; }
        public bool taxCalculated { get; set; } = false;

        public void RequestTaxCalculation(decimal amount)
        {
            taxAmount = taxRate * amount;
            taxCalculated = true;
        }
        public bool CheckTaxResult()
        {
            return taxCalculated;
        }
        public decimal GetTaxAmount()
        {
            return taxAmount;
        }
    }
}
