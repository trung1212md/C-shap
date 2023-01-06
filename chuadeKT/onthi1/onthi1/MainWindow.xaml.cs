using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace onthi1
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

         private void window_click(object sender, RoutedEventArgs e)
        {

            DataProcessing data = new DataProcessing();
            DataTable tableProduct = new DataTable();
            tableProduct = data.GetAllProduct(); //đã có bảng dữ liệu product
            //datagird.DataSource = tableProduct;
        }
        private void btthem_Click(object sender, RoutedEventArgs e)
        {
            string name = "car";
            string qty = "10";
            string price = "10000000";
            string proId = "20";
            InsertNewProduct("TTT",name, qty, price, proId);
            Console.WriteLine("Add");
        }
        private void InsertNewProduct(string id,string name, string qty, string price, string proId)
        {

            string query = "INSERT INTO SANPHAM (MA,TEN,SOLUONG,DONGGIA,MALOAI) VALUES('"+id+"','"+name+"',"+qty+","+price+",'"+proId+"')";
            Console.WriteLine(query);   
            SqlConnection cn = DBconcestion.SqlServerConnection();


            cn.Open();
            Console.WriteLine(cn);
            //DBconcestion.que (query);
            cn.Close();
        }

        private void datagird_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                
        }

       
    }
}
