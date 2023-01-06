using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace onthi1
{
    class DataProcessing
    {
        DBconcestion dBconcestion = new DBconcestion();

        public DataTable GetAllProduct()
        {
            string sql = "select * from SANPHAM";
            DataTable table = new DataTable();
            table = dBconcestion.GetTable(sql);
            return table;
        }
        public DataTable GetAllLOAI()
        {
            string sql = "select * from HangSX";
            DataTable table = new DataTable();
            table = dBconcestion.GetTable(sql);
            return table;
        }
        public void InsertProduct(int maSP, string tenSP, int soLuong, int maHang)
        {
            String sql = "Insert Into SanPham Values('" + maSP + "', '" + tenSP + "', '" + soLuong + "', '" + maHang + "')";
            dBconcestion.ExecuteNonQuery(sql);
        }

        public void EditProduct(int maSP, string tenSP, int soLuong, int maHang)
        {
            //String sql = $"update SanPham set TenSP = {tenSP}, SoLuong = {soLuong}, MaHang = {maHang} where MaSP = {maSP}";
            String sql = "Update SanPham Set TenSP=N'" + tenSP + "', SoLuong='" + soLuong + "', MaHang='" + maHang + "' Where MaSP='" + maSP + "'";
            dBconcestion.ExecuteNonQuery(sql);
        }

        public void DeleteProductById(int id)
        {
            String sql = "Delete SanPham Where MaSP='" + id + "'";
            dBconcestion.ExecuteNonQuery(sql);
        }


        public string FindTenHangByMaHang(int maHang)
        {
            string sql = "select TenHang from HangSX where MaHang = '" + maHang + "'";
            DataTable table = new DataTable();
            table = dBconcestion.GetTable(sql);
            return table.Rows[0].ItemArray[0].ToString();
        }
    }
}
