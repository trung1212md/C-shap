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
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Data;
using System.Xml;
using System.Reflection;

namespace Luyen_tap_KTHP
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
        DaTaProcessing data = new DaTaProcessing();
        private void Window_load(object sender, RoutedEventArgs e)
        {
            DataTable table = new DataTable();
            table = data.ShowAlltblTheLoai1();
            griddata.DataContext = table;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           


           
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e, DataGrid griddata)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

      
    }
}
