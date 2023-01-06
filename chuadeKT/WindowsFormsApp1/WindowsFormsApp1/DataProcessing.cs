using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     class DataProcessing
    {
        DBConnection dBConnection=new DBConnection();

        public DataTable getAlltblTaiLieu()
        {
            string sql = "select*from tblTaiLieu";
            DataTable table= new DataTable();
            table=dBConnection.GetTable(sql);
            return table;
        }

        public DataTable getAlltblTheLoai1()
        {
            string sql = "select*from tblTheLoai1";
            DataTable table = new DataTable();
            table = dBConnection.GetTable(sql);
            return table;
        }

        public void InserttblTaiLieu(string matailieu ,string tentailieu,string tacgia,int dongia,string matheloai)
        {
            string sql = "insert into theloai values('" + matailieu + "','" + tentailieu + "','" + tacgia + "','" + dongia + "','" + matheloai + "')";
            dBConnection.ExecuteNonQuery(sql);
        }

        public void EdittblTaiLieu(string matailieu, string tentailieu, string tacgia, int dongia, string matheloai)
        {
            string sql = "update  theloai set mattailieu('" + matailieu + "',ten tai lieu'" + tentailieu + "',tac gia'" + tacgia + "',don gia'" + dongia + "',ma the loai'" + matheloai + "')";
            dBConnection.ExecuteNonQuery(sql);
        }

        public void DeletetblTaiLieu(string matailieu)
        {
            String sql = "Delete SanPham Where MaSP='" + matailieu + "'";
            dBConnection.ExecuteNonQuery(sql);
        }

        public string FindtentailieuBytentailieu(int tentailieu)
        {
            string sql = "select TenHang from HangSX where MaHang = '" + tentailieu + "'";
            DataTable table = new DataTable();
            table = dBConnection.GetTable(sql);
            return table.Rows[0].ItemArray[0].ToString();
        }

        internal void InserttblTaiLieu()
        {
            throw new NotImplementedException();
        }
    }
}
