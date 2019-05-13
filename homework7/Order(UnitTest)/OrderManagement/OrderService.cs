using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._2
{
    [Serializable]
     public class OrderService
    {
        private List<Order> Orderlist;

        public OrderService()
        {
            Orderlist = new List<Order>();
        }

        public List<Order> Allorders()
        {
            return Orderlist;
        }

        //添加订单
        public void add(Order order)
        {
            foreach (Order i in Orderlist)
            {
                if (i.no.Equals(order.no))
                    throw new Exception($"订单号-{order.no} 已存在!");
            }
            Orderlist.Add(order);
        }

        //获得订单号
        public Order GetNo(int no)
        {
            foreach (Order i in Orderlist)
                if (i.no == no)
                    return i;
            return null;
        }
        //修改订单
        public void modify(int no, Order order)
        {
            Order i = GetNo(no);
            if (i == null) return;
            i = order;
        }
        //按照客户名查询订单（使用LINQ语句）
        public List<Order> FindClient(string client)
        {
            var query = Orderlist
                .Where(order => order.client == client);
            return query.ToList();
        }
        //按照订单号查询订单（使用LINQ语句）
        public List<Order> FindNo(int no)
        {
            List<Order> result = new List<Order>();
            var query = from i in Orderlist
                        from o in i.orderdetails
                        where o.myno == no
                        select i;
            return query.ToList();

        }
        //删除订单
        public void delete(int no)
        {
            Order order = GetNo(no);
            if (order == null) return;
            Orderlist.Remove(order);
        }

        public void Export(String filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            
            try
            {
                xmlSerializer.Serialize(fs, this.Orderlist);
            }
            catch
            {

            }
            fs.Close();
        }

        public void Import(String filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            try
            {
                this.Orderlist = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            catch
            {

            }
            fs.Close();  
        }
    }
}
