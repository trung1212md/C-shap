using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap1
{
    public class Vang9999:Hang
    {
        public int tuoivang;
        public override void nhap()
        {
            Console.WriteLine("nhap thong tin vang 9999");
            base.nhap();
            Console.WriteLine("nhap  tuoi vang");
            tuoivang=int.Parse(Console.ReadLine());

        }

        public int giavang()
        {
            int phucap ;
            if(tuoivang>=5)
            {
                return phucap = 1500000;
            }
            else
            {
                return phucap = 0;
            }

            return tuoivang * 5100000 + phucap;
        }
        public override void xuat()
        {
            Console.WriteLine("Thong tin vang 9999");
            base.xuat();
            Console.WriteLine("gia vang 9999:"+giavang());
        }

       

    }
}
