using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Процент скидки
        /// </summary>
        public int Discount { get; set; }
        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
