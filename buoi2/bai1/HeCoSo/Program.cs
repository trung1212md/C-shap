using System;
using System.Collections.Generic;
using System.Text;

namespace HeCoSo2
{
    class HeCoSo2
    {
        
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap n");
            string st=Console.ReadLine();
            n= Convert.ToInt32(st);
            Console.Write("So {0} trong he co so 2 la: {1}", n, Convert.ToString(n, 2));
            Console.Write("\nSo {0} trong he co so 8 la: {1}", n, Convert.ToString(n, 8));
            Console.Write("\nSo {0} trong he co so 10 la: {1}", n, Convert.ToString(n, 10));
            Console.Write("\nSo {0} trong he co so 16 la: {1}", n, Convert.ToString(n, 16));
        }
    }
}