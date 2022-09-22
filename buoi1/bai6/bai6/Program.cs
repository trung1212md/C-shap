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
            string st=Console.ReadLine();
            n= Convert.ToInt32(st);

            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 1)
                {
                    Console.WriteLine("so nguyen to la {0}", i);
                    break;
                }
            }

        }
    }
}
