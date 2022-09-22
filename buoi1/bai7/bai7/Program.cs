using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n");
            string st = Console.ReadLine();
            n = int.Parse(st);

            if (n < 2)
            {
                Console.WriteLine("ko co");

            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 1)
                    {
                        Console.WriteLine("so nguyen to {0}", n);
                    }
                    else
                    {
                        Console.WriteLine("ko phai so nguyen to");
                        break;
                    }
                }
            }

        }
    }
}
