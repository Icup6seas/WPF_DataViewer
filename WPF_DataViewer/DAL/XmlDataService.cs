using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WinForms_DataViewer
{
    public class XmlDataService : IDataService
    {
        private string _dataFilePath;

        public List<Product> ReadAll()
        {
            List<Product> products = new List<Product>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("Products"));

            try
            {
                StreamReader reader = new StreamReader(_dataFilePath);
                using (reader)
                {
                    products = (List<Product>)serializer.Deserialize(reader);
                }

            }
            catch (Exception)
            {
                throw;
            }

            return products;
        }

        public void WriteAll(List<Product> products)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new XmlRootAttribute("Products"));

            try
            {
                StreamWriter writer = new StreamWriter(_dataFilePath);
                using (writer)
                {
                    serializer.Serialize(writer, products);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public XmlDataService(string datafile)
        {
            _dataFilePath = datafile;
        }
    }
}
