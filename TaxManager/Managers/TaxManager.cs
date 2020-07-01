using System;
using System.Collections.Generic;
using System.Text;
using TaxManagerApp.Accessors;

namespace TaxManagerApp.Managers
{
    public class TaxManager
    {
        private IAccessorFactory _accessorFactory;

        public TaxManager(IAccessorFactory accessorFactory)
        {
            _accessorFactory = accessorFactory;
        }
        public decimal CalculateTax(string country)
        {
            decimal taxAmount = -1;

            // Get the subtotal
            ISubtotal subtotal = _accessorFactory.CreateAccessor<ISubtotal>();

            // Get the right tax rate accessor
            ITaxRate tax = _accessorFactory.CreateAccessor<ITaxRate>(country);

            // Check to see if a tax rate accessor was created
            if (tax != null)
            {
                // Have the tax rate accessor calculate the tax amount
                tax.RequestTaxCalculation(subtotal.GetSubtotal());

                // Check to see if accessor was able to calculate the tax
                bool taxResult = tax.CheckTaxResult();

                // Get the tax amount if accessor was able to calculate taxes
                if (taxResult == true)
                {
                    taxAmount = tax.GetTaxAmount();
                }
            }

            return taxAmount;
        }
    }
}
