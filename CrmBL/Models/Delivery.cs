using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Models
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ID поставщика
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Предполагаемая дата получения заказа
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Трек-код для отслеживания
        /// </summary>
        public string TrackCode { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
