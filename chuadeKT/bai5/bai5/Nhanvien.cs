using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class Nhanvien:Canbo
    {
        public string Congviec { get; set; }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap cong viec");
            Congviec=Console.ReadLine();
        }
        public void xuat()
        {
            base.xuat();
            Console.WriteLine("cong viec" + Congviec);
        }
    }
}
