using System;
using System.Collections.Generic;
using System.Text;
using TaxManagerApp.Accessors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxManagerTests
{
    [TestClass]
    public class AccessorFactoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidAccessorType()
        {
            // Arrange
            IAccessorFactory factory = new AccessorFactory();

            // Act
            var accessor = factory.CreateAccessor<string>();

            // Assert
            // none - expect an exception to be thrown
        }
    }
}
