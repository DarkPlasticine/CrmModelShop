using System;
using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Check
    {
        public int CheckId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public DateTime CreateDateTime { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
        public override string ToString()
        {
            return $"#{CheckId} от {CreateDateTime.ToString("dd.MM.yy hh:mm:ss")}#";
        }
    }
}
