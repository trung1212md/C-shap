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
            int n;
            Console.WriteLine("nhap n");
            string st=Console.ReadLine();
            int s = 0;
            n= Convert.ToInt32(st);
            for(int i = 1; i < n; i++)
            {
                s += i;
            }
            Console.WriteLine("tong s={0}", s);
            float s1 = 0;
            for (int i = 1; i < n; i++)
            {
                s1 +=(float)1.0/i;
            }
            Console.WriteLine("tong s1={0}", s1);
        }
    }
}
