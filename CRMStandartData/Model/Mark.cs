using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrmBL.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Название марки табака
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
