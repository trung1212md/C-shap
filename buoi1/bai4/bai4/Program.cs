using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int bacluong, ngaycong, phucap;
            Console.WriteLine("nhap bac luong");
            String st=Console.ReadLine();
            bacluong=int.Parse(st);
            Console.WriteLine("nhap ngay cong");
             st = Console.ReadLine();
            ngaycong =int.Parse(st);
            Console.WriteLine("nhap phu cap");
             st = Console.ReadLine();
            phucap =int.Parse(st);

            int NCTL;
            if (ngaycong >= 25)
            {
                NCTL=25+(ngaycong-25)*2;
                Console.WriteLine("luong tien linh {0}", bacluong * 1490000 * NCTL + phucap);
            }
            else
            {
                NCTL=ngaycong;
                Console.WriteLine("luong tien linh {0}",bacluong*1490000+NCTL+phucap);

            }
           
        }
    }
}
