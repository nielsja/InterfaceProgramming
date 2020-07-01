using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TaxManagerApp.Managers;

namespace TaxManagerTests
{
    [TestClass]
    public class TaxManagerTests
    {
        [TestMethod]
        public void CalculateTax_InvalidCountry()
        {
            // Arrange
            var factory = new MockAccessorFactory();
            var manager = new TaxManager(factory);

            // Act
            var result = manager.CalculateTax("Z");

            // Assert
            Assert.AreEqual(-1.00m, result);
        }

        [TestMethod]
        public void CalculateTax_Successful()
        {
            // Arrange
            var subTotal = new MockSubtotal();
            subTotal.subtotal = 100.00m;

            var taxRate = new MockTaxRate();
            taxRate.taxRate = 0.09m;

            var factory = new MockAccessorFactory();
            factory.MockSubtotal = subTotal;
            factory.MockTaxRate = taxRate;

            var manager = new TaxManager(factory);

            // Act
            var result = manager.CalculateTax("US");

            // Assert
            Assert.AreEqual(9.00m, result);
        }

    }
}
