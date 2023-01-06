using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Nhanvien:Nguoi
    {
        public string MaNV { get; set; }
        public string Chucvu { get; set; }

        public int luongcoban { get; set; }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap ma nhan vien");
            MaNV=Console.ReadLine();
            Console.WriteLine("nhap chuc vu");
            Chucvu=Console.ReadLine();
            Console.WriteLine("Luong co ban");
            luongcoban = Convert.ToInt32(Console.ReadLine());
        }
        public int tinhheso()
        {

            if (Chucvu == "Giam doc")
            {
                return 10;
            }
            else if (Chucvu == "Truong phong " || Chucvu == "Pho giam doc") 
            {
                return 6;
            }
            else if(Chucvu == "pho phong")
            {
                return 4;

            }
            return 2;

        }
    }
}
