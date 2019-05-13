using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTest_UI_
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void func()
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
}
