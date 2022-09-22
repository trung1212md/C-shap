using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0 && n >= 0)
            {
                Console.WriteLine("chan");
            }
            else if (n % 2 == 1 && n >= 0)
            {
                Console.WriteLine("le");
            }
            else if (n % 2 == 0 && n <= 0)
            {
                Console.WriteLine("chan am");
            }
            else
            {
                Console.WriteLine("le am");
            }

        }
    }
}
