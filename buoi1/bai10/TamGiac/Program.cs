using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("nhap a");
            String st=Console.ReadLine();
            a=int.Parse(st);
            Console.WriteLine("nhap b");
            st=Console.ReadLine();
            b=int.Parse(st);
            Console.WriteLine("nhap c");
            st = Console.ReadLine();
            c=int.Parse(st);
            int cv=a+b+c;
            System.Console.WriteLine("chu vi tam giac {0}", cv);
            float P = (a + b + c) / 2;
            float dt =(float) Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine("dien tich {0}",dt);


        }
    }
}
