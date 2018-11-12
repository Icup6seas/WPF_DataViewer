using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private void btn_Details_Click(object sender, RoutedEventArgs e)
        {
            Details_Window details = new Details_Window();
            details.Show();
        }

        private void btn_DelSel_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
            Help_Window help = new Help_Window();
            help.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var productList = XElement.Load(@"Data/PlaystationProducts.xml");
            this.dataGrid.DataContext = productList;
        }
    }
}
