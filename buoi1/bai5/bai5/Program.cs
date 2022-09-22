using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n tu 1 den 7");
            string st=Console.ReadLine();
            n= Convert.ToInt32(st);
            switch (n) { 
                case 1:
                    Console.WriteLine("chu nhat");
                    break;
                case 2:
                    Console.WriteLine("thu hai");
                    break;
                case 3:
                    Console.WriteLine("thu ba");
                    break;
                case 4:
                    Console.WriteLine("thu bon");
                    break;
                case 5:
                    Console.WriteLine("thu nam");
                    break;
                case 6:
                    Console.WriteLine("thu sau");
                    break;
                case 7:
                    Console.WriteLine("thu bay");
                    break;

                    default:
                    Console.WriteLine("het chuong trinh roi ong oi");
                    break ;


            }




        }
    }
}
