using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WPF_DataViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Product> _products;

        public MainWindow()
        {
            InitializeComponent();
        }

        //
        //Closes application
        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //
        //Opens Detail window
        private void btn_Details_Click(object sender, RoutedEventArgs e)
        {
            Details_Window details = new Details_Window();
            details.Show();

        }

        //
        //Delete selected row
        private void btn_DelSel_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid == null)
            {
                MessageBox.Show("Cannot delete the blank Entry");
            }
            else
            {
                //dataGrid.SelectedItems.RemoveAt(dataGrid.SelectedItems);
                //MessageBox.Show("Deleted");
            }
        }

        //
        //Opens the Help window
        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
            Help_Window help = new Help_Window();
            help.Show();
        }

        //
        //Loads Data to the Datagrid from the XML file
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var productList = XElement.Load(@"Data/PlaystationProducts.xml");
            this.dataGrid.DataContext = productList;
        }
    }
}
