using luyen_tap_thi_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace luyen_tap_thi_1
{
    /// <summary>
    /// Interaction logic for sua1.xaml
    /// </summary>
    public partial class sua1 : Window
    {
        QLBANHANGContext db;
         MainWindow mainWindow = new MainWindow();
        public sua1()
        {
            InitializeComponent();
        }
       
       
        //sua
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new QLBANHANGContext();
            var spsua = db.SanPham2s.SingleOrDefault(sp => sp.MaSp == txtMaSP.Text);
            if (spsua == null)
            {
                MessageBox.Show("Không có sản phẩm này...");
                txtMaSP.Text = "";
            }
            else
            {
                try
                {
                    spsua.MaSp = txtMaSP.Text;
                    spsua.TenSp = tensanphamtxt.Text;
                    spsua.SoLuong = int.Parse(soluongtxt.Text);
                    spsua.DonGia = int.Parse(soluongtxt.Text);
                    spsua.MaLoai = maloaitxt.Text;

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                mainWindow.Show();
                this.Close();



            }
        }
            // TIM KIEM
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            db = new QLBANHANGContext();
            var spsua = db.SanPham2s.SingleOrDefault(sp => sp.MaSp == txtMaSP.Text);
            if (spsua == null)
            {
                MessageBox.Show("Không có sản phẩm này...");
                txtMaSP.Text = "";
            }
            else
            {
                  masanphamtxt.Text= spsua.MaSp;
                 tensanphamtxt.Text= spsua.TenSp;
               soluongtxt.Text = spsua.SoLuong.ToString();
                 dongiatxt.Text= spsua.DonGia.ToString();
                maloaitxt.Text=spsua.MaLoai;
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }
    }
}
