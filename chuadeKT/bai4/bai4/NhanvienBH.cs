using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class NhanvienBH:Nhanvien
    {
        public int solg { get; set; }


        public NhanvienBH():base()
        {
            solg = 0;
        }

        public NhanvienBH(string hoten,DateTime NgayTD,int solg) :base(hoten,NgayTD)
        {
            this.solg = solg;
        }

        public int tinhtienhoahong()
        {
            if(solg<100)
            {
                return 1000;
            }
            else if(solg>100&&solg<500)
            {
                return 2000;
            }
            else
            {
                return 3000;
            }
        }
    }
}
