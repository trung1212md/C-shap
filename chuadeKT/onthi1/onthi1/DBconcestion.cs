using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthi1
{
    internal class DBconcestion
    {

        
        public static SqlConnection SqlServerConnection()
        {
            
            string connectionString = @"Data Source=localhost\SQLEXPRESS" +
                                  ";Initial Catalog=SANPHAM" +
                                  ";Persist Security Info=True;" +
                                  "Integrated Security=True;Encrypt=True;TrustServerCertificate=True;" +
                                  "User Instance=False;User ID=trung1212md user;Password=trung1212md";
            SqlConnection cn = new SqlConnection(connectionString);
            return cn;
        }

        public DataTable GetTable(string sql)
        {
            SqlConnection conn = SqlServerConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataTable table= new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void ExecuteNonQuery(string sql) //cho chèn, xóa, sửa
        {
            SqlConnection conn = SqlServerConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
