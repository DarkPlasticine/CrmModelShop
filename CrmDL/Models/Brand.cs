using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrmDL.Models
{
    public class Brand: BaseObject
    {
        /// <summary>
        /// Название марки табака
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
