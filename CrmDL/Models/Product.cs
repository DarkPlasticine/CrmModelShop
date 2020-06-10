using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrmDL.Models
{
    /// <summary>
    /// Класс продукта
    /// </summary>
    public class Product: BaseObject
    {
        /// <summary>
        /// ID марки табака
        /// </summary>
        [Required]
        public int MarkId { get; set; }

        /// <summary>
        /// Вкус
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Закупочная цена
        /// </summary>
        [Required]
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; } = 0;

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Штрих-код пачки
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// Рейтинг табака
        /// </summary>
        public decimal Rating { get; set; }

        /// <summary>
        /// Вес упаковки
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Скидка на табак
        /// </summary>
        public int Discount { get; set; }

        public virtual Mark Mark { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
        public override string ToString()
        {
            return $"{Mark.Name} - {Name}";
        }
    }
}
