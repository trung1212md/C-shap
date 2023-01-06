using System;
using System.Collections.Generic;

#nullable disable

namespace luyen_tap_thi_1.Models
{
    public partial class LoaiSanPham1
    {
        public LoaiSanPham1()
        {
            SanPham2s = new HashSet<SanPham2>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<SanPham2> SanPham2s { get; set; }
    }
}
