using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyen_tap_KTHP
{
     class DaTaProcessing
    {
        DBconnection dataConn = new DBconnection();

        public DataTable ShowAlltblTaiLieu()
        {
            string sql = "Select * from tblTaiLieu";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public DataTable ShowAlltblTheLoai1()
        {
            string sql = "select * from tblTheLoai1";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }
        public void InserttblTaiLieu(string MaTaiLieu, string TenTaiLieu, string TacGia, int DonGia, string MaTheLoai)
        {
            String sql = "Insert Into tblTaiLieu Values('" + MaTaiLieu + "', '" + TenTaiLieu + "', '" + TacGia + "', '" + DonGia + "', '" + MaTheLoai + "')";
            dataConn.ExecuteNonQuery(sql);
        }

        public void EdittblTaiLieu(string MaTaiLieu, string TenTaiLieu, double TacGia, int DonGia, string MaTheLoai)
        {
            String sql = "Update tblTaiLieu Set TenTaiLieu='" + MaTaiLieu + "', TacGia='" + TenTaiLieu + "', DonGia='" + TacGia + "', DonGia='" + DonGia + "' Where MaTheLoai ='" + MaTheLoai + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        public void DeletetblTaiLieu(string MaTaiLieu)
        {
            String sql = "Delete Products Where MaTaiLieu='" + MaTaiLieu + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public string GetCategoryNameByID(string id)
        {
            string sql = "select CategoryName from Category where CategoryID = '" + id + "'";
            DataTable table = new DataTable();
            table = dataConn.ExecuteReturnTable(sql);

            return table.Rows[0].ItemArray[0].ToString();
        }

        internal DataTable ShowAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
