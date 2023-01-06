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

namespace ontap2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public string name { get; set; }
        public List<string> tags { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public string price { get; set; }
        public Window1(string name, List<string> tags, string type, string date, string price)
        {

            this.name = name;
            this.tags = tags;
            this.type = type;
            this.date = date;
            this.price = price;
            InitializeComponent();
            txtName.Text = name;    
            txtPrice.Text = price;
            cbxType.ItemsSource= tags;
            cbxType.Text = type;
            datePicker.Text = date;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
