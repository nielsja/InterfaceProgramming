using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManagerApp.Accessors
{
    class Subtotal : ISubtotal
    {
        public decimal GetSubtotal()
        {
            var random = new Random();
            return random.Next(0, 100);
        }
    }
}
