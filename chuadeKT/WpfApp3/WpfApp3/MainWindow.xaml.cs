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
using WpfApp3.Models;

namespace WpfApp3
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
            ShowKhoa();
        }
        // xuat ra bang
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
                            VienPhi=bn.SoNgayNamVien*200000
                            
                        };
            listBN.ItemsSource = query.ToList();
        }

     private void ShowKhoa()
        {
            var query = from k in db.Khoas select k;
            khoa.ItemsSource = query.ToList();
            khoa.DisplayMemberPath = "MaKhoa";
            khoa.SelectedValuePath = "TenKhoa";
            khoa.SelectedIndex = 0;
        }

        private bool Check()
        {
            string mess = "";
            if(mabn.Text==""||hoten.Text==""||songaynv.Text==""||diachi.Text=="")
            {
                mess += "nhap cac truong du lieu";
            }
            else
            {
                int maBn;
                if(!int.TryParse(mabn.Text,out maBn))
                {
                    mess += "ma benh nhan la so duong";
                }
                int SoNgayNamVien;
                if(!int.TryParse(songaynv.Text,out SoNgayNamVien))
                    {
                    mess += "so gay nam vien la so duong";
                }
                else if(SoNgayNamVien<0)
                {
                    mess += "so ngay nam vien >0";
                }
            }
            if(!mess.Equals(""))
            {
                MessageBox.Show(mess, "thong bao");
                return false;
            }
            return true;
        }

     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Check())
            {
                var benhnhan=db.BenhNhans.SingleOrDefault(b=>b.MaBn.Equals(int.Parse(mabn.Text)));
                if(benhnhan!=null)
                {
                    MessageBox.Show(" co ma benh nhan");
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
        //day data len cot
       
        //sua
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var benhnhan = db.BenhNhans.SingleOrDefault(b => b.MaBn.Equals(int.Parse(mabn.Text)));

            if(benhnhan!=null)
            {
                if(Check())
                {

                    benhnhan.MaBn = int.Parse(mabn.Text);
                    benhnhan.HoTen = hoten.Text;
                    benhnhan.DiaChi = diachi.Text;
                    benhnhan.SoNgayNamVien = int.Parse(songaynv.Text);
                    Khoa k = (Khoa)khoa.SelectedItem;
                    benhnhan.MaKhoa = k.MaKhoa;

                  
                    db.SaveChanges();
                    MessageBox.Show("sua thanh cong");
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
        //xoa
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var benhnhan = db.BenhNhans.SingleOrDefault(b => b.MaBn.Equals(int.Parse(mabn.Text)));

            if(benhnhan!=null)
            {
                MessageBoxResult result = MessageBox.Show("ban co chac mion xoa", "thong bao", MessageBoxButton.YesNo);
                if(result==MessageBoxResult.Yes)
                {
                    db.BenhNhans.Remove(benhnhan);
                    db.SaveChanges();
                    MessageBox.Show("xoa thanh cong");
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
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            var query = from bn in db.BenhNhans
                        where bn.MaKhoa == 1
                        orderby bn.SoNgayNamVien descending
                        select new {

                            bn.MaBn,
                            bn.HoTen,
                            bn.MaKhoa,
                            bn.DiaChi,
                            bn.SoNgayNamVien,
                            VienPhi = bn.SoNgayNamVien * 20000
                        };
            window1.listBN.ItemsSource = query.ToList();
            window1.Show();



        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
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
                            VienPhi = bn.SoNgayNamVien * 20000
                        };
            window2.listBN.ItemsSource = query.ToList();
            window2.Show();
        }

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
    }
}
