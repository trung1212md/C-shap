using System;
using System.Collections.Generic;

#nullable disable

namespace luyen_tap_thi_1.Models
{
    public partial class Loaisanpham
    {
        public Loaisanpham()
        {
            Sanpham1s = new HashSet<Sanpham1>();
            Sanphams = new HashSet<Sanpham>();
        }

        public string Maloai { get; set; }
        public string Tenloai { get; set; }

        public virtual ICollection<Sanpham1> Sanpham1s { get; set; }
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
