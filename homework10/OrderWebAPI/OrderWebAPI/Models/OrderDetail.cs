using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderWebAPI.Models
{
    public class OrderDetail
    {
        [Key]
        public string Id { get; set; }
        public string GoodsName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public OrderDetail()
        {
            Id = Guid.NewGuid().ToString();
        }

        public OrderDetail(string id, string goodsname, double price, int count)
        {
            Id = id;
            GoodsName = goodsname;
            Price = price;
            Count = count;
        }

        public override bool Equals(object obj)
        {
            var goods = obj as OrderDetail;
            return goods != null && Id == goods.Id;
        }
    }
}
