using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            Console.Write("nhap n");
            String tr = Console.ReadLine();
            int n=int.Parse(tr);
            int kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq=kq*i;
            }
            Console.WriteLine(kq);
        }
    }
}
