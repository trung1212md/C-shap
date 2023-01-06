using System;
using System.Collections.Generic;

#nullable disable

namespace luyen_tap_thi_1.Models
{
    public partial class HoaDonChiTiet
    {
        public string MaHd { get; set; }
        public string MaSp { get; set; }
        public int? SoLuongMua { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; }
        public virtual SanPham2 MaSpNavigation { get; set; }
    }
}
