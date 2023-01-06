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
using Microsoft.EntityFrameworkCore;
using QLSanPham.Models;
namespace QLSanPham
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLySanPhamContext db = new QuanLySanPhamContext();
        //SanPham sp;
        public MainWindow()
        {
            InitializeComponent();
            //this.sp = sp;
        }
        public void renderData()
        {
            var dataQuery = from qlsp in db.SanPhams
                            select qlsp;
            //GridSP.ItemsSource = dataQuery.ToList();
        }
        private void windowLoaded(object sender, RoutedEventArgs e)
        {
            renderData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //var ma = int.Parse(txtMa.Text);
            var ten = txtTen.Text;
            var soLuong = int.Parse(txtSoLuong.Text);
            var donGia = decimal.Parse(txtDonGia.Text);
            int maLoai = int.Parse(txtMaLoai.Text);

            db.SanPhams.Add(new SanPham(ten,soLuong,donGia,maLoai));
             db.SaveChanges();
            renderData();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var itemSelectedToDel = GridSP.SelectedItem as SanPham;
            db.SanPhams.Remove(itemSelectedToDel);
            db.SaveChanges();
            renderData();
        }

        private void btnAlter_Click(object sender, RoutedEventArgs e)
        {
            SanPham sp = GridSP.SelectedItem as SanPham;
            var spSua = db.SanPhams.SingleOrDefault(t => t.Ma.Equals(sp.Ma));
            if(spSua != null)
            {
                AlterSanPham alterSanPham = new AlterSanPham(spSua,db);
                alterSanPham.Show();
                this.Close();
            }
        }

        private void GridSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            renderData();
        }
    }
}
