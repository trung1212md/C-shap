using luyen_tap_thi_1.Models;
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


namespace luyen_tap_thi_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        QLBANHANGContext db;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        // THEM
        public void renderData()
        {
            // tạo lớp context
            db = new QLBANHANGContext();
            //tao query
            var sanphamquery = from sp in db.SanPham2s
                               join loai in db.LoaiSanPham1s
                               on sp.MaLoai equals loai.MaLoai
                               select new
                               {
                                   masp = sp.MaSp,
                                   tensp=sp.MaSp,
                                   soluong=sp.SoLuong,
                                   dongia=sp.DonGia,
                                   tenloai=loai.TenLoai

                               };
           datagrid.ItemsSource = sanphamquery.ToList();



        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           renderData();
        }
        // them
        private void btthem_Click(object sender, RoutedEventArgs e)
        {
            SanPham2 sanpham = new SanPham2();
            try
            {
                sanpham.MaSp = txtmasp.Text;
                
                sanpham.TenSp = txtmasp.Text;
                sanpham.SoLuong = int.Parse(txtsoluong.Text);
                sanpham.DonGia = int.Parse(txtdongia.Text);
                sanpham.MaLoai = txtmaloai.Text;
            }
            catch(Exception err)
            {
                MessageBox.Show("sai kieu du lieu");
            }   
            // theem list vao danh sach
            db.SanPham2s.Add(sanpham);

            db.SaveChanges();
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch(Exception err)
            //{
            //    MessageBox.Show("Trùng mã sản phẩm kìa!!!");
            //}
            var sanphamquery = from sp in db.SanPham2s
                               join loai in db.LoaiSanPham1s
                               on sp.MaLoai equals loai.MaLoai
                               select new
                               {
                                   masp = sp.MaSp,
                                   tensp = sp.MaSp,
                                   soluong = sp.SoLuong,
                                   dongia = sp.DonGia,
                                   tenloai = loai.TenLoai

                               };
            datagrid.ItemsSource = sanphamquery.ToList();

            txtmasp.Text = "";
            txtmasp.Focus();
            txttensp.Text = "";
            txtsoluong.Text = "";
            txtdongia.Text = "";
            txtmaloai.Text = "";
            renderData(); 


            //Tạo đối tượng do user nhập
            
        }
            
        // thoát
        private void btthoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //sửa
        private void btsua_Click(object sender, RoutedEventArgs e)
        {
            sua1 sua1 = new sua1();
            sua1.Show();
            this.Close();
        }
        // xóa
        private void btxoa_Click(object sender, RoutedEventArgs e)
        {
            Xoa xoa = new Xoa();
            xoa.Show();
            this.Close();
        }

       
    }
}
