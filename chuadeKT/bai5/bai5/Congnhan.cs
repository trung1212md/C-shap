using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class Congnhan:Canbo
    {

        public int Bacluong { get; set; }

        public void nhap()

        {
            base.nhap();
            do
            {
                Console.WriteLine("nhap bac luong 1->9");
                Bacluong=Convert.ToInt32(Console.ReadLine());
            }
            while (Bacluong<0&&Bacluong>9);
        }

        public void xuat()
        {
            base.xuat();
            Console.WriteLine("bac luong " + Bacluong);
        }
    }
}
