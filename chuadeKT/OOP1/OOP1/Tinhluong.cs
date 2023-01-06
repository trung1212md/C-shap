using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     public class Tinhluong
    {
        public string hoten { get; set; }
        public string diachi { get; set; }
        public int HeSoLuong { get; set; }
        public int luongcoban { get; set; }


        public Tinhluong()
        {
            this.HeSoLuong = 1000000;
        }

        public Tinhluong(string hoten, string diachi,int hesoluong, int luongcoban)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.HeSoLuong = hesoluong;
            this.luongcoban = luongcoban;

        }
        public virtual float Getluong()
        {
            return luongcoban* HeSoLuong;
        }

    }
}
