using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace TESTS1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection con=new SqlConnection("Data Source=HoangCongTrung\\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void updateGird()
        {
            DataClass
        }
    }
}
