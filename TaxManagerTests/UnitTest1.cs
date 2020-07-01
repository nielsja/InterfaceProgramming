using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxManagerApp;

namespace TaxManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Test method reached";
            string actual = new Program().TestMethod();
            Assert.AreEqual(expected, actual);
        }
    }
}
