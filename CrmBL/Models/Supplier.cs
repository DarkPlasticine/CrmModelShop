using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Мобильный номер телефона
        /// </summary>
        public string PhoneNum { get; set; }

        /// <summary>
        /// Рабочий телефон
        /// </summary>
        public string WorkPhone { get; set; }

        /// <summary>
        /// Факс
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Название фирмы
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Адрес (улица или п/я)
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Область/край/республика
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Surname} {Name} {Lastname}";
        }
    }
}
