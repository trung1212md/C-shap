using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baiso5
{
    public class Nhanvien
    {

        public string Hoten { get; set; }
        public bool gioitinh { get; set; }

        public DateTime Ngaytuyendung { get; set; }

        public Nhanvien()
        {

        }
        public Nhanvien(string hoten, bool gioitinh, DateTime ngaytuyendung)
        {
            this.Hoten = hoten;
            this.gioitinh = gioitinh;
            this.Ngaytuyendung = ngaytuyendung;
        }
        public virtual string Totring()
        {
            return $"{Hoten,20}{gioitinh,20}{Ngaytuyendung.ToString("dd-MM-yyyy"),20}";
        }
    }
}
