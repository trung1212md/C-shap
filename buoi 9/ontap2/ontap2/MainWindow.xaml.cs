using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ontap2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listType;
        List<Nhanvien> listNhanvien;
        public MainWindow()
        {
            InitializeComponent();
            listType = new List<string>() { "Cơ hữu", "Hợp đồng", "Cộng tác viên" };
            cbxType.ItemsSource = listType;
            listNhanvien = new List<Nhanvien>();
            ListNV.DataContext = listNhanvien;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // name
            string ptnName = @"^[A-Za-z\s]+$";
            Regex rgName = new Regex(ptnName);
            string name = txtName.Text;
            // type
            string type = cbxType.Text;
            // date
            string ptnDate = @"^([1-9]|1[0-2])[\/]([[1-9]|[12]\d|3[01])[\/]((19|20)\d{2})$";
            Regex rgDate = new Regex(ptnDate);
            string datetime = date.Text;
            date.Text = "";
            // price
            string ptnPrice = @"^[0-9]+(\.[0-9]+)*$";
            Regex rgPrice = new Regex(ptnPrice);
            string strPrice = txtPrice.Text;

            if (name == "" || type == "" || datetime == "" || strPrice == "")
            {
                MessageBox.Show("Làm ơn nhập đầy đủ!!!");
                return;
            }
            else
            {
                if (!rgName.IsMatch(name))
                {
                    MessageBox.Show("Nhập lại tên đi!!!");
                    txtName.Text = "";
                    return;
                }

                if (type == "")
                {
                    MessageBox.Show("Chọn loại đi!!!");
                    return;
                }

                if (!rgDate.IsMatch(datetime))
                {
                    MessageBox.Show("Nhập lại ngày đi!!!");
                    return;
                }
                else
                {
                    string year = "";
                    int len = datetime.Length;
                    for (int i = len - 4; i < len; i++)
                    {
                        year = year + datetime[i];
                    }
                    int intYear = DateTime.Now.Year - int.Parse(year);
                    if (intYear < 19 || intYear > 60)
                    {
                        MessageBox.Show("Nhập lại ngày đi!!!");
                        return;
                    }
                }

                if (!rgPrice.IsMatch(strPrice))
                {
                    MessageBox.Show("Nhập lại giá đi!!!");
                    return;
                }

            }
            double price;
            price = double.Parse(strPrice);
            listNhanvien.Add(new Nhanvien(name, type, datetime, price));
            ListNV.Items.Refresh();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nhanvien = (Nhanvien)ListNV.SelectedItem;
           if(nhanvien == null)
            {
                MessageBox.Show("Không có nhân viên nào được chọn");
                return;
            }
            string nameNhanvien = nhanvien.name;
            string typeNhanvien = nhanvien.type;
            string dateNhanvien=nhanvien.date;
            string priceNhanvien=Convert.ToString(nhanvien.price);
            Window1 window1 = new Window1(nameNhanvien,listType, typeNhanvien, dateNhanvien, priceNhanvien);
            window1.Show();
        }

        private void ListNV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nv = (Nhanvien)ListNV.SelectedItem;
            listNhanvien.Remove(nv);
            ListNV.Items.Refresh();
            txtName.Text = "";
            txtName.Focus();
            txtPrice.Text = "";
            date.Text = DateTime.Today.ToString();
            cbxType.Text = "";
        }
    }
}
