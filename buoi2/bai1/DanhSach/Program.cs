using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
{
    internal class Program
    {
         public static void Check(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("chan ");

            }
            else
            {
                Console.WriteLine("le");
            }


        }
        public static void nguyento(int n)
        {
            if (n < 2)
            {
                Console.WriteLine("ko co so nguyen to");
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if(n%i == 0)
                    {
                        Console.WriteLine("{0}",i);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n");
            string st=Console.ReadLine();
            n=int.Parse(st);
            Check(n);
            nguyento(n);

            

        }
    }
}
