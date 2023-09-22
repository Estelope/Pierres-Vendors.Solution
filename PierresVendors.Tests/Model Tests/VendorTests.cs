using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {        
            Vendor newVendor = new Vendor("Test Vendor", "Vendor Description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsVendorName_String()
        {
            string name = "Test Vendor";
            Vendor newVendor = new Vendor(name, "Vendor Description");
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }
    }
}