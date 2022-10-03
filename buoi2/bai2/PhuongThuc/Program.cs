using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] a;
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            a=new int[n];

            for(int i=0; i<n; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<n; i++)
            {
                if (TestNT(a[i]))
                    Console.WriteLine(a[i]);
            }
        }

      
        }
        public static bool TestNT(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
                else
                    return true;
            }
        }
    
}
