using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AllordersTest()
        {
            OrderService os = new OrderService();
            Order order1 = new Order(1, "Apple", "Frank");
            Order order2 = new Order(2, "HUAWEI", "Jasmine");
            OrderDetails details1 = new OrderDetails(1, 1, 6999);
            OrderDetails details2 = new OrderDetails(2, 1, 3899);

            order1.AddDetails(details1);
            order2.AddDetails(details2);

            os.add(order1);
            os.add(order2);
            Assert.IsNotNull(os.Allorders());
        }

        [TestMethod()]
        public void addTest()
        {
            OrderService os = new OrderService();
            Order order1 = new Order(1, "Apple", "Frank");
            OrderDetails details1 = new OrderDetails(1, 1, 6999);
            order1.AddDetails(details1);
            os.add(order1);
            Assert.IsNotNull(os.Allorders());
        }

        [TestMethod()]
        public void GetNoTest()
        {
            OrderService os = new OrderService();
            Order order1 = new Order(1, "Apple", "Frank");
            OrderDetails details1 = new OrderDetails(1, 1, 6999);
            order1.AddDetails(details1);
            Order od = os.GetNo(order1.no);
            Assert.IsNotNull(od);
        }

        [TestMethod()]
        public void modifyTest()
        {
            OrderService os = new OrderService();
            OrderService os1 = new OrderService();
            Order order1 = new Order(1, "Apple", "Frank");
            Order order2 = new Order(2, "HUAWEI", "Jasmine");
            OrderDetails details1 = new OrderDetails(1, 1, 6999);
            OrderDetails details2 = new OrderDetails(2, 1, 3899);

            order1.AddDetails(details1);
            order2.AddDetails(details2);

            os.add(order1);
            os1.add(order2);
            os.modify(1, order2);
            Assert.AreEqual(os,os1);
        }

        [TestMethod()]
        public void FindClientTest()
        {
            OrderService os = new OrderService();
            Order order1 = new Order(1, "Apple", "Frank");
            OrderDetails details1 = new OrderDetails(1, 1, 6999);
            order1.AddDetails(details1);
            Order od = os.GetNo(order1.no);
            List<Order> OS = os.FindClient(order1.client);
            Assert.IsNotNull(OS);
        }

        [TestMethod()]
        public void FindNoTest()
        {
            OrderService os = new OrderService();
            Order order3 = new Order(3, "Samsung", "Excelsior");
            OrderDetails details3 = new OrderDetails(3, 2, 2699);
            order3.AddDetails(details3);
            os.add(order3);
            List<Order> OS = os.FindNo(order3.no);
            Assert.IsNotNull(OS);
        }

        [TestMethod()]
        public void deleteTest()
        {
            OrderService os = new OrderService();
            OrderService os1 = new OrderService();
            Order order1 = new Order(1, "Apple", "Frank");
            Order order2 = new Order(2, "HUAWEI", "Jasmine");
            OrderDetails details1 = new OrderDetails(1, 1, 6999);
            OrderDetails details2 = new OrderDetails(2, 1, 3899);

            order1.AddDetails(details1);
            order2.AddDetails(details2);

            os.add(order1);
            os.add(order2);
            os1.add(order2);
            os.delete(1);
            Assert.AreEqual(os, os1);
        }

    }
}