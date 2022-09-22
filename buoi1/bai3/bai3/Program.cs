using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a, b;
            Console.WriteLine("nhap a");
            string st=Console.ReadLine();
            a=int.Parse(st);
            Console.WriteLine("nhap b");
            st=Console.ReadLine();  
            b=int.Parse(st);



            if (a == 0)
            {
                Console.WriteLine("b=0");

            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("vo so nghiem");
                }
                else
                {

                    Console.WriteLine("x={0}",(float)b/a);
                }

            }

            int c;
            Console.WriteLine("nhap c");
            st = Console.ReadLine();
            c=int.Parse(st);
            /*bai 3 b phương trình bậc hai: ax2 + bx + c = 0*/
            if (a == 0)
            {
                Console.WriteLine("pt co nghiem {0}",(float)c/b);
            }
            else
            {
                float denta = b * b - 4 * a * c;
                if (denta> 0)
                {
                    Console.WriteLine(" nghiem thu nhat {0}", (float)((-b + Math.Sqrt(denta)) / 2 * a));
                    Console.WriteLine(" nghiem thu nhat {0}", (float)((-b - Math.Sqrt(denta)) / 2 * a));
                }
                else
                {
                    Console.WriteLine("vo nghiem");
                }
            }

        }
    }
}
