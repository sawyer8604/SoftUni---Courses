using System.Xml.Serialization;

namespace CarDealer.DataTransferOject.InputModels
{
    [XmlType("partId")]
    public class CarPartsInputModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}