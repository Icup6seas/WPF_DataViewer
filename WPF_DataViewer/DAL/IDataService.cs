using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DataViewer
{
    public interface IDataService
    {
        List<Product> ReadAll();
        void WriteAll(List<Product> products);
    }
}
