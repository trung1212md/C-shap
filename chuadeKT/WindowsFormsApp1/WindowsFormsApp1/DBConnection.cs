using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DBConnection
    {
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=HoangCongTrung\SQLEXPRESS;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True");
        }

        public DataTable GetTable(string sql)
        {
            SqlConnection conn= GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table= new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = GetSqlConnection();
            conn.Open();
            SqlCommand cmd =new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
        }
    }
}
