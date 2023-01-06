using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baiso5
{
    public class Nhanvienthoivu:Nhanvien
    {
        public int songaylamviec { get; set; }


        public Nhanvienthoivu():base()
        {

        }

        public Nhanvienthoivu(string hoten,bool gioitinh,DateTime Ngaytuyendung, int songaylamviec) :base(hoten,gioitinh, Ngaytuyendung)
        {
            this.songaylamviec = songaylamviec;
        }

        public int tinhtien()
        {
            if(songaylamviec <=10)
            {
                return songaylamviec*200000;
            }
            else
            {
                return 2000000+(songaylamviec-10)*400000;
            }
        }
    }
}
