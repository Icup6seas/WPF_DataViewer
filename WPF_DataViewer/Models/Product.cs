using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DataViewer
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        public string DateReleased { get; set; }
        public string Media { get; set; }
        public double UnitsSold { get; set; }
        public string Manufacturer { get; set; }
        public string ImageFileName { get; set; }

        public string ProductNameAndNumber()
        {
            return ProductName + (Number != null ? " " + Number : "");
        }
    }
}
