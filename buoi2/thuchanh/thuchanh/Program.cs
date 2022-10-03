using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh
{
    internal class Program
    {
        public static void nhap(int[]a,int n)
        {
           
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void xuat(int[]a,int n)
        {
            Console.WriteLine("xuat ra mang ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
           public static void timCL(int[]a,int n)
        {
            for(int i=0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(" so chan {0}", a[i]);
                }
                if (a[i] % 2 == 1)
                {
                    Console.WriteLine(" so le {0}", a[i]);
                }
            }
        }
        static void Main(string[] args)

        {
            int[] a;
            int n;
            n=Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            nhap(a, n);
            xuat(a, n);
            Console.WriteLine("tim chan le");
            timCL(a, n);







        }
    }
}
