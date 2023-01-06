using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap1
{
    public class VangTrang:Hang
    {
        public int trongluong;
        public override void nhap()
        {
           
            Console.WriteLine("nhap thong tin vang Trang");
            base.nhap();
            Console.WriteLine("nhap  tuoi vang");
            trongluong = int.Parse(Console.ReadLine());

        }

        public float giavang()
        {
            float hoahong;
            
            if (trongluong > 3)
            {
                return hoahong =1790000*1;
            }
            else
            {
                return hoahong = 1790000*(float)0.5;
            }

            return trongluong * trongluong + hoahong;
        }
        public override void xuat()
        {
            Console.WriteLine("thong tin vang trang");
            base.xuat();
            Console.WriteLine("gia vang trang" + giavang());
        }
    }
}
