using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cautruc
{
    internal class Program
    {
        struct hocsinh {
           public string hoten;
            public int tuoi;
            public  bool gioitinh;

        }

        static void Main(string[] args)
        {
            hocsinh[] a = new hocsinh[10];
            int s = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("nhap thong tin hoc sinh");
                Console.WriteLine("nhap Ho ten hoc sinh");
                a[i].hoten=Convert.ToString(Console.ReadLine());
                Console.WriteLine("nhap tuoi hoc sinh");
                a[i].tuoi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap gioi tinh hoc sinh");
                a[i].gioitinh = Convert.ToBoolean(Console.ReadLine());
                s += a[i].tuoi;
            }
            Console.WriteLine("tong so tuoi hoc sinh s={0}",s);
        }
    }
}
