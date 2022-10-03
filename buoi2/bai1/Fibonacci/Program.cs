using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n;
            Console.WriteLine("nhập n");
            string tr=Console.ReadLine();
            n=int.Parse(tr);
            int a = 0;
            int b = 1;
            int c = 1;
            Console.WriteLine("{0}", b);
            Console.WriteLine("{0}", c);


            for (int i = 3; i <=n; i++)
            {
                a = b + c;
                Console.WriteLine("{0}",a);
                b = c;
                c = a;

            }
            
      
                
        }
    }
}
