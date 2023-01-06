using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyentap3
{
    internal class Program
    {
        public static class NumberDemo
        {
        
        public static int x;
        public static int y;

        static NumberDemo()
        {
            x = 10;
            y = 20;
        }
        public static int add()
        {
            return x + y;
        }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("rs" + NumberDemo.add());
            NumberDemo.x = 100;
            NumberDemo.y = 200;
            Console.WriteLine("rs"+NumberDemo.add());
           
        }
    }
}
