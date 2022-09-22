using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dai, rong;

            Console.WriteLine("nhap dai");
            string st=Console.ReadLine();

             dai=float.Parse(st);
            Console.WriteLine("rong");
            st =Console.ReadLine();
            rong=float.Parse(st);

            float chuvi = (dai + rong) * 2;
            Console.WriteLine("chuvi {0}", chuvi);
            float dientich = dai * rong;
            Console.WriteLine("dien tich {0}",dientich);

        }
    }
}
