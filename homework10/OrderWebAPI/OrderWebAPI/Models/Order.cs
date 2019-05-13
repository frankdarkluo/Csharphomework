using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderWebAPI.Models
{
    public class Order
    {
        [Key]
        public string Id { get; set;}
        public string Client { get; set; }
        public double Price { get; set; }
        public List<OrderDetail> Detail{ get; set; }

        public Order()
        {

        }
        public Order(string id,string client,double price,List<OrderDetail> detail)
        {
            Id = id;
            Client = client;
            Price = price;
            Detail = detail;
        }
    }
}
