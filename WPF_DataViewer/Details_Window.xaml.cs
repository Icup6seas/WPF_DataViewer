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
using System.Windows.Shapes;

namespace WPF_DataViewer
{
    /// <summary>
    /// Interaction logic for Details_Window.xaml
    /// </summary>
    public partial class Details_Window : Window
    {
        public Details_Window()
        {
            InitializeComponent();
        }

        private void btn_Details_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
