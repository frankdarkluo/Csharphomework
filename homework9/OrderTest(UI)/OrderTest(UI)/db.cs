namespace homework9._2
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;

    public partial class orderdb : DbContext
    {
        public orderdb() : base("name=orderdb") { }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    public class Order
    {
        [Key]
        public String orderId { get; set; }
        public List<OrderDetail> details { get; set; }

        public Order()
        {
            details = new List<OrderDetail>();
        }

        public Order(String orderId,List<OrderDetail> details)
        {
            this.orderId = orderId;
            this.details = details;
        }
    }

    public class OrderDetail
    {
        [Key]
        public String itemId { get; set; }
        public String itemName { get; set; }
        public int itemAmount { get; set; }

        public OrderDetail() { }

        public OrderDetail(String itemId, String itemName, int itemAmount)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.itemAmount = itemAmount;
        }
    }
}
