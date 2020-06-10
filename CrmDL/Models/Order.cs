using System;

namespace CrmDL.Models
{
    public class Order:BaseObject
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public DateTime DateTime { get; set; }
        
        
    }
}