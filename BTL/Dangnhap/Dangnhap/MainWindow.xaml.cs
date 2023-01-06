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

namespace Dangnhap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // lay dữ liệu tài khoản mật khẩu nhập vào
            string taikhoan=txtTaikhoan.Text;

            // chua chuyen dc thanh dau cham bi
            string matkhau=txtMatkhau.Text;
            if(taikhoan=="")
            {
                MessageBox.Show("Bạn chưa nhập vào tài khoản");
            }

            else if (matkhau == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else
            {

                if(taikhoan=="congtrung" && matkhau=="123456")
                {
                    MessageBox.Show("Đăng nhập thành Công ");
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu bị sai ");
                    txtMatkhau.Focus();// đưa tài khoản mật khẩu về ô mật khẩu
                    txtMatkhau.SelectAll();//tô đen  tất cả text trong mật khẩu
                }
            }


                
        }

        // tạo enter để đăng nhập
        private void txtMatkhau_Keydown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
