using System.Xml.Serialization;

namespace CrmBL.Models
{
    [XmlType]
    public class Messages
    {
        [XmlElement] public string ErrorDbConnection { get; set; }
    }
}
