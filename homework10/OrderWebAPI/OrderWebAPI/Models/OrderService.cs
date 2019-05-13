using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderWebAPI.Models
{
    public class OrderService
    {
        private readonly Context ordermenu;
        public OrderService(Context orderctx)
        {
            this.ordermenu = orderctx;
        }
        public void add(Order order)
        {
            ordermenu.Entry(order).State = EntityState.Added;
            ordermenu.SaveChanges();
        }
        public void delete(string orderno)
        {
            var order = ordermenu.Orders.Include("Detail").SingleOrDefault(o => o.Id == orderno);
            ordermenu.OrderDetails.RemoveRange(order.Detail);
            ordermenu.Orders.Remove(order);
            ordermenu.SaveChanges();
        }

        public void modify(Order new_order)
        {
            delete(new_order.Id);
            foreach(OrderDetail detail in new_order.Detail)
            {
                ordermenu.Entry(detail).State = EntityState.Added;
            }
            ordermenu.Entry(new_order).State = EntityState.Added;
            ordermenu.SaveChanges();
        }

        public Order GetOrder(string no)
        {
            return ordermenu.Orders.Include("Detail").SingleOrDefault(o => o.Id == no);
        }

        public List<Order> Allorders()
        {
            return ordermenu.Orders.Include("Detail").ToList<Order>();
        }

        public List<Order> GetbyClient(string client)
        {
            return ordermenu.Orders.Include("Detail").Where(o => o.Client.Equals(client)).ToList<Order>();
        }

        public List<Order> GetByGoods(string Name)
        {
            var stuff = ordermenu.Orders.Include("Detail").
                Where(o => o.Detail.Where(
                    item => item.GoodsName.Equals(Name)).Count() > 0);
            return stuff.ToList<Order>();
        }
    }
}
