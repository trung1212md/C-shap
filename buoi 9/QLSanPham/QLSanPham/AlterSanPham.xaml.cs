using QLSanPham.Models;
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
using QLSanPham.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace QLSanPham
{
    /// <summary>
    /// Interaction logic for AlterSanPham.xaml
    /// </summary>
    public partial class AlterSanPham : Window
    {
        //public int ma { get; set; }
        //public string? ten { get; set; }
        //public decimal? donGia { get; set; }
        //public int? soLuong { get; set; }
        //public int? maLoai { get; set; }
        public SanPham sp { get; set; }
        QuanLySanPhamContext quanLySanPhamContext = new QuanLySanPhamContext();
        public AlterSanPham(SanPham sp,QuanLySanPhamContext db)
        {
            InitializeComponent();
            quanLySanPhamContext = db;
            this.sp = sp;
            //this.ma = sanpham.Ma;
            //this.ten = sanpham.Ten;
            //this.soLuong = sanpham.SoLuong;
            //this.donGia = sanpham.DonGia;
            //this.maLoai = sanpham.MaLoai;
        }
        private void WindowLoadedS(object sender, RoutedEventArgs e)
        {
            lbMa.Content = sp.Ma.ToString();
        }
        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            if(txtTen.Text != "")
                sp.Ten = txtTen.Text;
            if(txtSoLuong.Text != "")
                sp.SoLuong = int.Parse(txtSoLuong.Text);
            if(txtDonGia.Text != "")
                sp.DonGia = decimal.Parse(txtDonGia.Text);
            if (txtMaLoai.Text != "")
                sp.MaLoai = int.Parse(txtMaLoai.Text);
            var spSua = quanLySanPhamContext.SanPhams.SingleOrDefault(t => t.Ma.Equals(sp.Ma));
            spSua = sp;
            quanLySanPhamContext.SaveChanges();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        
    }
}
