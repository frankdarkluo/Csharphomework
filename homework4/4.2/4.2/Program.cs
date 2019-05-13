/*写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、

查询订单（按照订单号、商品名称、客户等字段进行查询）功能。

在订单删除、修改失败时，能够产生异常并显示给客户错误信息。

提示：需要写Order（订单）、OrderDetails（订单明细），OrderService（订单服务）几个类，

订单数据可以保存在OrderService中一个List中。*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Order
    {
        public string no, name, client;//订单号，商品名称，客户

        public Order() { }

        public Order(string No,string Name,string Client)
        {
            no = No;
            name = Name;
            client = Client;
        }

        public void Output()
        {
            Console.WriteLine("订单号: " + this.no);
            Console.WriteLine("商品名称: " + this.name);
            Console.WriteLine("客户: " + this.client);
            Console.WriteLine("购买商品数量: 1");
            Console.WriteLine("购买价格: 10");
        }
    }

    class OrderDetails
    {
        public int count, price;//商品数量，商品价格
        OrderDetails() { }
        OrderDetails(int Count,int Price)
        {
            count = Count;
            price = Price;
        }
    }

    class OrderService
    {
        List<Order> Orderlist = new List<Order>();

        //添加订单
        public void add()
        {
            Order order = new Order();
            Console.Write("订单号: ");
            order.no = Console.ReadLine();
            Console.Write("商品名称: ");
            order.name = Console.ReadLine();
            Console.Write("客户名: ");
            order.client = Console.ReadLine();
            Orderlist.Add(order);
            Console.WriteLine("添加订单成功！");
        }

        //删除订单
        public void delete()
        {
            Boolean flag = false;
            Console.WriteLine("请输入需要删除订单的订单号:");
            string delno=Console.ReadLine();
            for(int i=0;i<Orderlist.Count;i++)
            {
                if(Orderlist[i].no==delno)//找到订单号
                {
                    Orderlist.Remove(Orderlist[i]);//删除
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("删除订单失败！");
                throw new Exception();
            }
            else Console.WriteLine("删除订单成功！");
        }

        //修改订单
        public void modify()
        {
            Boolean flag = false;
            Console.WriteLine("请输入需要修改订单的订单号:");
            string modino = Console.ReadLine();
            foreach(Order order in Orderlist)
            {
                if(order.no==modino)//找到订单号
                {
                    Console.Write("请输入想修改成的客户名:");
                    string modi_client = Console.ReadLine();
                    order.client = modi_client;//修改
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("修改订单失败！");
                throw new Exception();
            }
            else Console.Write("修改订单成功！");
        }

        //查询订单
        public void search()
        {
            Console.WriteLine("1:按订单号查询 2.按商品名称查询 3.按客户名查询");
            int ch = Int32.Parse(Console.ReadLine());
            List<Order> Searchlist = new List<Order>();
            try
            {
                switch(ch)
                {
                    case 1:
                        {
                            Console.WriteLine("请输入数据:");
                            string data = Console.ReadLine();
                            foreach (Order order in Orderlist)//寻找
                            {
                                if (order.no == data)//找到数据
                                {
                                    order.Output();//输出
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("请输入数据:");
                            string data = Console.ReadLine();
                            foreach (Order order in Orderlist)
                            {
                                if (order.name == data)
                                {
                                    order.Output();
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("请输入数据:");
                            string data = Console.ReadLine();
                            foreach (Order order in Orderlist)
                            {
                                if (order.client == data)
                                {
                                    order.Output();
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("输入错误!");
                            break;
                        }
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("无订单!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("订单管理控制台程序如下,请选择功能:");
            OrderService order = new OrderService();
            while (true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1.添加订单 2.删除订单 3.修改订单 4.查询订单 5.退出");
                Console.WriteLine("---------------------------------------------------");
                int ch = Int32.Parse(Console.ReadLine());
                if (ch == 5) break;
                switch (ch)
                {
                    case 1:order.add(); break;
                    case 2:order.delete(); break;
                    case 3:order.modify();break;
                    case 4:
                            try
                            {
                                order.search();
                            }
                            catch
                            {
                                Console.WriteLine("查询订单失败！");
                            }
                            break;
                    default:
                        {
                            Console.WriteLine("输入错误!");
                            break;
                        }
                }
            }
        }
    }
}
