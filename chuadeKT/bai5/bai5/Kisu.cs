using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class Kisu:Canbo
    {
        public string Nganhdaotao { get; set; }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap nganh dao tao");
            Nganhdaotao=Console.ReadLine();
        }
        public void xuat()
        {
            base.xuat();
            Console.WriteLine("ngang dao tao");

        }


    }
}
