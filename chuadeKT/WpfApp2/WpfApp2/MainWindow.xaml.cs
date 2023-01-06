using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using WpfApp2.Models;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLyBenhNhanDBContext db = new QuanLyBenhNhanDBContext();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Showdata();
            Showkhoa();
        }

        private void Showdata()
        {
            var query = from bn in db.BenhNhans
                        orderby bn.SoNgayNamVien descending
                        select new
                        {
                            bn.MaBn,
                            bn.HoTen,
                            bn.MaKhoa,
                            bn.DiaChi,
                            bn.SoNgayNamVien,
                      
                            VienPhi = bn.SoNgayNamVien * 20000
                        };
            listBN.ItemsSource = query.ToList();

        }
        private void Showkhoa()
        {
            var query = from k in db.Khoas select k;
            khoa.ItemsSource = query.ToList();
            khoa.DisplayMemberPath = "TenKhoa";
            khoa.SelectedValuePath = "MaKhoa";
            khoa.SelectedIndex = 0;

        }

        private bool Checkdata()
        {
            string mess = "";
            if(mabn.Text==""||hoten.Text==""||diachi.Text==""||songaynv.Text=="")
            {
                mess += "chua nhap cac truong ";
            }
            else
            {
                int maBn;
                if(!int.TryParse(mabn.Text,out maBn))
                {
                    mess += "ma benh nhan la so duong";
                }
                int SoNgayNhapVien;
                if(!int.TryParse(songaynv.Text,out SoNgayNhapVien))
                {
                    mess += "so ngay nhap vien la so duong";

                }
                else if(SoNgayNhapVien<1)
                {
                    mess += "so ngay nhap vien >0";
                }
            }
            if(!mess.Equals(""))
            {
                MessageBox.Show(mess, "thong bao");
                return false;
            }
            return true;
        }
        // them
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Checkdata())
            {
                var benhnhan = db.BenhNhans.SingleOrDefault(b => b.MaBn.Equals(int.Parse(mabn.Text)));
                if (benhnhan != null)
                {
                    MessageBox.Show("ma benh nhan da co");
                }
                else
                {
                    BenhNhan bn = new BenhNhan();
                    bn.MaBn = int.Parse(mabn.Text);
                    bn.HoTen = hoten.Text;
                    bn.DiaChi = diachi.Text;
                    bn.SoNgayNamVien = int.Parse(songaynv.Text);
                    Khoa k = (Khoa)khoa.SelectedItem;
                    bn.MaKhoa = k.MaKhoa;

                    db.BenhNhans.Add(bn);
                    db.SaveChanges();
                    MessageBox.Show("them thanh cong");
                    mabn.Clear();
                    hoten.Clear();
                    diachi.Clear();
                    songaynv.Clear();
                    mabn.Focus();
                    khoa.SelectedIndex = 0;
                    Showdata();
                }
            }
        }
        // tim
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            var query = from bn in db.BenhNhans
                        where bn.MaKhoa == 1
                        orderby bn.SoNgayNamVien descending
                        select new
                        {
                               bn.MaBn,
                               bn.HoTen,
                               bn.MaKhoa,
                               bn.DiaChi,
                               bn.SoNgayNamVien,
                               VienPhi=bn.SoNgayNamVien*2000000
                        };
            window.listBN.ItemsSource = query.ToList();
            window.Show();
        }

        // day len bang

        private void listBN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listBN.SelectedItem!=null)
            {
                Type t = listBN.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                mabn.Text = p[0].GetValue(listBN.SelectedValue).ToString();
                hoten.Text = p[1].GetValue(listBN.SelectedValue).ToString();
                diachi.Text = p[3].GetValue(listBN.SelectedValue).ToString();
                songaynv.Text = p[4].GetValue(listBN.SelectedValue).ToString();
                khoa.SelectedValue = p[2].GetValue(listBN.SelectedValue).ToString();
            }
        }
        //sua
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var bnchange = db.BenhNhans.SingleOrDefault(b => b.MaBn.Equals(int.Parse(mabn.Text)));
          if(bnchange != null)
            {
                if(Checkdata())
                {
                    bnchange.MaBn = int.Parse(mabn.Text);
                    bnchange.HoTen = hoten.Text;
                    bnchange.DiaChi = diachi.Text;
                    bnchange.SoNgayNamVien = int.Parse(songaynv.Text);
                    Khoa k = (Khoa)khoa.SelectedItem;
                    bnchange.MaKhoa = k.MaKhoa;

                    
                    db.SaveChanges();
                    MessageBox.Show("xua thanh cong");
                    mabn.Clear();
                    hoten.Clear();
                    diachi.Clear();
                    songaynv.Clear();
                    mabn.Focus();
                    khoa.SelectedIndex = 0;
                    Showdata();
                }
            }


        }
        // xoa
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var bndelete = db.BenhNhans.SingleOrDefault(b => b.MaBn.Equals(int.Parse(mabn.Text)));
            if (bndelete != null)
            {
                MessageBoxResult result = MessageBox.Show("ban co muon xoa hay ko", "thoat", MessageBoxButton.YesNo);

                if (result==MessageBoxResult.Yes)
                {


                    db.BenhNhans.Remove(bndelete);
                    db.SaveChanges();
                    MessageBox.Show("xua thanh cong");
                    mabn.Clear();
                    hoten.Clear();
                    diachi.Clear();
                    songaynv.Clear();
                    mabn.Focus();
                    khoa.SelectedIndex = 0;
                    Showdata();
                }
            }
        }

         private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WindowTK windowTK = new WindowTK();

            var query = from bn in db.BenhNhans
                        join k in db.Khoas on
                        bn.MaKhoa equals k.MaKhoa
                        group bn by new { bn.VienPhi } into result
                        select new {
                           
                            VienPhi = result.Count()
                        };
            windowTK.listBN.ItemsSource = query.ToList();
            windowTK.Show();

        }
    }
}

