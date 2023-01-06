﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Luyen_tap_KTHP
{
    class DBconnection
    {

        
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=HoangCongTrung\SQLEXPRESS;Initial Catalog=Demo2;Integrated Security=True");
        }

        public SqlConnection
        public DataTable GetTable(string sql) //dang viết cho câu lệnh select
        {
            SqlConnection conn = GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn); //Chuyển đổi dữ liệu ra adapter
            DataTable table = new DataTable();
            adapter.Fill(table); //Đổ data ra table
            return table;
        }

        public void ExecuteNonQuery(string sql) //cho chèn, xóa, sửa
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

    }
}
