using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phieubai1
{
    internal class Program
    {
       class Circle
        {
            public int radius { get; set; }

            public void input()
            {
                Console.WriteLine("nhap  radius");
                radius =Convert.ToInt32(radius);
            }

            public Circle()
            {
                radius = 0;
            }
            public Circle(int radius)
            {
                this.radius = radius;
            }

            public double Area(int radius)
            {
                return radius * radius * 3.14; 
            }

            public double Perimeter(int radius)
            {
                return 2 * 3.14 * radius;
            }
        }
        static void Main(string[] args)
        {
           Circle circle = new Circle();
            circle.input();
            Console.WriteLine( "dien tich"+circle.Area(circle.radius));
            Console.WriteLine("chu vi"+circle.Perimeter(circle.radius));

            circle.Area(3);
            circle.Perimeter(3);
            
        }
    }
}
