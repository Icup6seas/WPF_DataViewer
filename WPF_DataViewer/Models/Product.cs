using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPF_DataViewer
{
    public class Product
    {
        [XmlElement("ID")]
        public int Id { get; set; }
        [XmlElement("Playstation Version")]
        public string ProductName { get; set; }
        [XmlElement("Number")]
        public int Number { get; set; }
        [XmlElement("MSRP")]
        public double Price { get; set; }
        [XmlElement("Date Released")]
        public string DateReleased { get; set; }
        [XmlElement("Media")]
        public string Media { get; set; }
        [XmlElement("Units Sold")]
        public double UnitsSold { get; set; }
        [XmlElement("Manufacturer")]
        public string Manufacturer { get; set; }
        public string ImageFileName { get; set; }

        public string ProductNameAndNumber()
        {
            return ProductName + (Number != null ? " " + Number : "");
        }
    }
}
