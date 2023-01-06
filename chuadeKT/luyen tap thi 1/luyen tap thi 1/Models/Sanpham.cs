using System;
using System.Collections.Generic;

#nullable disable

namespace luyen_tap_thi_1.Models
{
    public partial class Sanpham
    {
        public string Masp { get; set; }
        public string Tensanpham { get; set; }
        public string Maloai { get; set; }
        public int? Soluong { get; set; }
        public int? Dongia { get; set; }

        public virtual Loaisanpham MaloaiNavigation { get; set; }
    }
}
