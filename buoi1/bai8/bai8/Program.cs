using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n");
            string st=Console.ReadLine();
            n= Convert.ToInt32(st);
           for(int i = 0; i < n; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("so nguyen {0}", i);
                }
            }
        }
    }
}
