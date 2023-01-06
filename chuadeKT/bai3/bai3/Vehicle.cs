using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class Vehicle
    {
        public  string HangSX { get; set; }
        public string Mausac { get; set; }

        public virtual void nhap()
        {
            Console.WriteLine("nhap hang sx");
            HangSX=Console.ReadLine();
            Console.WriteLine("nhap mau sac");
            Mausac =Console.ReadLine();
        }

    }
}
