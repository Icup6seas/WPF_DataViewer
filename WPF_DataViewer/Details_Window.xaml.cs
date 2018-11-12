using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_DataViewer
{
    /// <summary>
    /// Interaction logic for Details_Window.xaml
    /// </summary>
    public partial class Details_Window : Window
    {
        Product _model = new Product();

        public Details_Window()
        {
            InitializeComponent();
            
        }

        //public Details_Window(Product model)
        //{
        //    InitializeComponent();
        //    _model = model;
        //}


        //
        //Details Window Load Form
        //private void DetailForm_Load(object sender, EventArgs e)
        //{
        //    lbl_ProductName = _model.ProductNameAndNumber();
        //    lbl_RetailPrice.Text = "Retail Price: " + "$" + _model.Price.ToString();
        //    lbl_ReleaseDate.Text = "Release Date: " + _model.DateReleased.ToString();
        //    lbl_UnitsSold.Text = "Units Sold: " + _model.UnitsSold.ToString() + " Million";
        //    lbl_Media.Text = "Supported Media: " + _model.Media.ToString();
        //    lbl_Manufacturer.Text = "Manufacturer: " + _model.Manufacturer.ToString();
        //    image_Picture.Image = Image.FromFile(@"Images/" + _model.ImageFileName);
        //}

        private void image_Picture_Click(object sender, EventArgs e)
        {

        }

        private void btn_Details_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
