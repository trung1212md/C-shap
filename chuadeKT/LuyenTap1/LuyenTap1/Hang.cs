using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap1
{
    public class Hang
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }

        public virtual void nhap()
        {
            Console.WriteLine("nhap Ma hang");
            MaHang=Console.ReadLine();
            Console.WriteLine("nhap Ten Hang");

        }
        public virtual void xuat()
        {
            Console.WriteLine("Ma hang:"+MaHang);
            Console.WriteLine("Ten hang:" + TenHang);

        }

    }
}
