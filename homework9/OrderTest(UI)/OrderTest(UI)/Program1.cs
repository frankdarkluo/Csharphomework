/*写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、

查询订单（按照订单号、商品名称、客户等字段进行查询）功能。

在订单删除、修改失败时，能够产生异常并显示给客户错误信息。

提示：需要写Order（订单）、OrderDetails（订单明细），OrderService（订单服务）几个类，

订单数据可以保存在OrderService中一个List中。*/
/*
using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderTest_UI_
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
                                   // 订单号，商品名，客户名
            Order order1 = new Order(1, "Apple", "Frank");
            Order order2 = new Order(2, "HUAWEI", "Jasmine");
            Order order3 = new Order(3, "Samsung", "Excelsior");
                                           //订单号，购买个数，单价
            OrderDetails details1 = new OrderDetails(1, 1, 6999);
            OrderDetails details2 = new OrderDetails(2, 1, 3899);
            OrderDetails details3 = new OrderDetails(3, 2, 2699);

            order1.AddDetails(details1);
            order2.AddDetails(details2);
            order3.AddDetails(details3);

            os.add(order1);
            os.add(order2);
            os.add(order3);

            os.Export("test.xml");
            
            Console.WriteLine("所有订单: ");
            List<Order> orders = os.Allorders();
                
            foreach (Order orderss in orders)
                Console.WriteLine(orderss.ToString());

            Console.WriteLine("按照客户名查询订单: Jasmine");
            orders = os.FindClient("Jasmine");
            foreach (Order order in orders)
                Console.WriteLine(order);

            Console.WriteLine("按照订单号查询订单: 1");
            orders = os.FindNo(1);
            foreach (Order order in orders)
                Console.WriteLine(order);

            Console.WriteLine("移除订单(no=1)并输出剩下所有订单");
            os.delete(3);//出问题了，记得检查
            os.Allorders().ForEach(od => Console.WriteLine(od));

            Console.WriteLine("按照订单总金额降序的顺序对订单进行排序输出");
            os.Allorders().Sort((o1, o2) => (int)(o2.GetSum() - o1.GetSum()));
            os.Allorders().ForEach(od => Console.WriteLine(od));

            os.Import("test.xml");

            Console.ReadKey();
        }    
    }
}*/
