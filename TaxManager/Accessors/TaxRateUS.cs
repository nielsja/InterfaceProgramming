using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManagerApp.Accessors
{
    class TaxRateUS : ITaxRate
    {
        private decimal _taxRate = 0.07m;
        private decimal _taxAmount;
        private bool _taxCalculated = false;

        public void RequestTaxCalculation(decimal amount)
        {
            _taxAmount = _taxRate * amount;
            _taxCalculated = true;
        }
        public bool CheckTaxResult()
        {
            return _taxCalculated;
        }
        public decimal GetTaxAmount()
        {
            return _taxAmount;
        }
    }
}
