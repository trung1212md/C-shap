using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    
    internal class Program
    {
        public static int giaithua(int n)
        {
            
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return giaithua(n - 1) * n;
            }
        }
        public static int t(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 && n == 2)
            {
                return 1;
            }
            else if (n >= 3)
            {
                return t(n - 1) + t(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n");
            string tr=Console.ReadLine();
            n=int.Parse(tr);
            Console.WriteLine("{0}", giaithua(n));
            Console.WriteLine("Fibonacci ");
            Console.WriteLine("{0}", t(n));
        }
        
    }
}
