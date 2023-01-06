using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class Nhanvien
    {

        public string hoten { get; set; }
        public DateTime NgayTD { get; set; }

        public Nhanvien()
        {

        }

        public Nhanvien(string hoten, DateTime ngayTD)
        {
            this.hoten = hoten;
            this.NgayTD = ngayTD;
        }
    }
}
