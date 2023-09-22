using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }
            [TestMethod]
        public void GetOrderPrice_ReturnsOrderPrice_String()
        {
            string orderPrice = "Order Price";
            Order newOrder = new Order(orderPrice, "Order Description", "Order Date");
            string result = newOrder.OrderPrice;
            Assert.AreEqual(orderPrice, result);
        }

    }

      

}