using System;
using System.Collections.Generic;

namespace Kiosk
{
    public class Order
    {
        public int OrderID { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public List<OrderItem> Items { get; set; }
            = new List<OrderItem>();

        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; }
    }
}