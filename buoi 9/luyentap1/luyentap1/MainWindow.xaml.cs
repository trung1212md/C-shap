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

namespace luyentap1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<sinhvien> sinhvienleft=new List<sinhvien>();
        List<sinhvien> sinhvienright=new List<sinhvien>();
        public MainWindow()
        {
            InitializeComponent();


            sinhvienleft.Add(new sinhvien(1, "nguyen van a", 10));
            sinhvienleft.Add(new sinhvien(1, "nguyen van c", 10));
            sinhvienleft.Add(new sinhvien(1, "nguyen van d", 10));
            sinhvienleft.Add(new sinhvien(1, "nguyen van e", 10));
            sinhvienleft.Add(new sinhvien(1, "nguyen van g", 10));
            leftBox.DataContext = sinhvienleft;
            rightBox.DataContext = sinhvienright;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sinhvien temp = (sinhvien)leftBox.SelectedItem;
            sinhvienright.Add(temp);
            rightBox.Items.Refresh();
            sinhvienleft.Remove(temp);
            leftBox.Items.Refresh();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sinhvien item = (sinhvien)rightBox.SelectedItem;
            sinhvienleft.Add((sinhvien)item);
            leftBox.Items.Refresh();
            sinhvienright.Remove(item);
            rightBox.Items.Refresh();
        }
    }
}
