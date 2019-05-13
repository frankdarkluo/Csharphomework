using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class OrderService
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
        //按照客户名查询订单
        public List<Order> FindClient(string client)
        {
            var query = Orderlist
                .Where(order => order.client == client);
            return query.ToList();
        }
        //按照订单号查询订单
        public List<Order> FindNo(int no)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in Orderlist)
            {
                foreach (OrderDetails detail in order.orderdetails)
                {
                    if (detail.myno == no)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }
        //删除订单
        public void delete(int no)
        {
            Order order = GetNo(no);
            if (order == null) return;
            Orderlist.Remove(order);
        }
    }
}
