using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CrmBL.Models 
{
    [XmlType]
    public class Language
    {
        public static List<Language> Load()
        {
            var xmlSerializer = new XmlSerializer(typeof(Language));
            string pathToLocales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages");
            var result = new List<Language>();

            foreach (var file in new DirectoryInfo(pathToLocales).GetFiles("*.xml"))
            {
                using (var reader = new XmlTextReader(file.FullName))
                {
                    var language = (Language)xmlSerializer.Deserialize(reader);
                    language.Name = Path.GetFileNameWithoutExtension(file.Name);
                    result.Add(language);
                }
            }

            return result;
        }

        public static void Save()
        {
            var xmlSerializer = new XmlSerializer(typeof(Language));
            string pathToLocales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages");

            var lan = new Language
            {
                EntitiesMenu = "Сущности",
                ProductMenuItem = "Табак",
                SellerMenuItem = "Продавец",
                Messages = new Messages
                {
                    ErrorDbConnection = "Text1"
                }
                
            };

            using (var reader = new XmlTextWriter(Path.Combine(pathToLocales, "Русский1.xml"), Encoding.UTF8))
            {
                xmlSerializer.Serialize(reader, lan);
            }
        }

        [XmlIgnore]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        #region Поля перевода

        [XmlElement] public string EntitiesMenu { get; set; }
        [XmlElement] public string ProductMenuItem { get; set; }
        [XmlElement] public string SellerMenuItem { get; set; }


        [XmlElement] public Messages Messages { get; set; }

        #endregion
    }
}
