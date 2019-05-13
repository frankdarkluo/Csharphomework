using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest_UI_
{
    [Serializable]
    public class Order : IComparable
    {
        public int no { get; set; }//订单号
        public string name { get; set; } //商品
        public string client { get; set; }//客户
        public List<OrderDetails> orderdetails = new List<OrderDetails>();
        public Order() { }

        public Order(int No, string Name, string Client)
        {
            no = No;
            name = Name;
            client = Client;
        }

        //获得订单总金额
        public double GetSum()
        {
            double sum = 0;
            foreach (OrderDetails detail in orderdetails)
                sum += detail.count * detail.price;
            return sum;
        }

        //添加订单明细
        public void AddDetails(OrderDetails orderdetail)
        {
            if (this.orderdetails.Contains(orderdetail))
                throw new Exception($"订单明细-{orderdetail} 已存在!");
            orderdetails.Add(orderdetail);
        }

        //删除订单明细
        public void RemoveDetails(int orderdetailno)
        {
            orderdetails.RemoveAll(d => d.myno == orderdetailno);
        }

        //Compareto函数
        public int Compareto(object obj)
        {
            return this.no - (obj as Order).no;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            if (obj is Order)
            {
                Order m = (Order)obj;
                if (m.no == no)
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            String result = $"订单号:{no}, 商品名称: {name}, 客户名: {client} ";
            orderdetails.ForEach(orderdetails => result += "\n\t" + orderdetails);
            return result;
        }

    }
}
