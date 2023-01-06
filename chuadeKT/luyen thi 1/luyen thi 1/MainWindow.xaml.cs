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

namespace luyen_thi_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private AccountService accountService;
        public MainWindow()
        {
            InitializeComponent();
            accountService =new  AccountService();
            loadData();
        }
        private void loadData()//load cbb-gird
        {
            foreach(var x in accountService.getlstlstRoles())
            {
                cbbquyen.Items.Add(x.Name);
            }
            cbbquyen.SelectedIndex = 0;

            //load data vào grid vieww
            datagrid.Columns
        }
    }
}
