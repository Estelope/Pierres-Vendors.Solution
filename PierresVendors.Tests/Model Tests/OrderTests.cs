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

            [TestMethod]
        public void GetOrderDescription_ReturnsOrderDescription_String()
        {
            string orderDescription = "Order Description";
            Order newOrder = new Order("Order Price", orderDescription, "Order Date");
            string result = newOrder.OrderDescription;
            Assert.AreEqual(orderDescription, result);
        }

            [TestMethod]
        public void GetOrderDate_ReturnsOrderDate_String()
        {
            string orderDate = "Order Date";
            Order newOrder = new Order("Order Price", "Order Description", orderDate);
            string result = newOrder.OrderDate;
            Assert.AreEqual(orderDate, result);
        }

            [TestMethod]
        public void GetOrderId_ReturnsOrderId_Int()
        {
            Order.ClearAll();
            Order newOrder = new Order("Order Price", "Order Description", "Order Date");
            int result = newOrder.Id;
            Assert.AreEqual(1, result);
        }

            [TestMethod]
        public void GetAll_ReturnsAllOrderObjects_OrderList()
        {
            Order.ClearAll();
            Order newOrder1 = new Order("Order Price 1", "Description 1", "Date 1");
            Order newOrder2 = new Order("Order Price 2", "Description 2", "Date 2");
            List<Order> expectedList = new List<Order> { newOrder1, newOrder2 };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(expectedList, result);
        }

            [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            Order.ClearAll();
            Order newOrder1 = new Order("Order Price 1", "Description 1", "Date 1");
            Order newOrder2 = new Order("Order Price 2", "Description 2", "Date 2");
            Order result = Order.Find(2);
            Assert.AreEqual(newOrder2, result);
        }



    }

      

}