using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManagerApp.Accessors
{
    public interface ITaxRate
    {
        public void RequestTaxCalculation(decimal amount);
        public bool CheckTaxResult();
        public decimal GetTaxAmount();
    }
}
