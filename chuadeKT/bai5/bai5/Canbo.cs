using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class Canbo
    {
        public string MACB { get; set; }
        public string Hoten { get; set; }
        public int namsinh { get; set; }

        public string gioitinh { get; set; }
        public string diachi { get; set; }

        public void nhap()
        {
            Console.WriteLine("nhap MaCB:");
            MACB=Console.ReadLine();
            Console.WriteLine("nhap Ho ten:");
            Hoten=Console.ReadLine();
            Console.WriteLine("nhap Nam sinh:");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap Gioi tinh:");
            gioitinh=Console.ReadLine();
            Console.WriteLine("nhap Dia chi:");
            diachi = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("MaCB:" + MACB);
            Console.WriteLine("Hoten:" + Hoten);
            Console.WriteLine("Nam sinh:" + namsinh);
            Console.WriteLine("Gioi tinh:" + gioitinh);
            Console.WriteLine("Dia chi:" + diachi);

        }
    }
}
