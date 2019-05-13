using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    public class OrderDetails
    {
        private List<OrderDetails> details = new List<OrderDetails>();

        public int myno, count, price;//订单号，商品数量，商品价格
        public OrderDetails() { }
        public OrderDetails(int Myno, int Count, int Price)
        {
            myno = Myno;
            count = Count;
            price = Price;
        }

        public override string ToString()
        {
            string result = "";
            result += $"  购买商品数量:{count}:  ";
            result += $"购买单价: {price}";
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is OrderDetails)
            {
                OrderDetails m = (OrderDetails)obj;
                if (m.myno == this.myno)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = 1522631281;
            hashCode = hashCode * -1521134295;
            hashCode = hashCode * -1521134295;
            return hashCode;
        }
    }
}
