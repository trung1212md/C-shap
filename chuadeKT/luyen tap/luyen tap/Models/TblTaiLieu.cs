using System;
using System.Collections.Generic;

#nullable disable

namespace luyen_tap.Models
{
    public partial class TblTaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenTaiLieu { get; set; }
        public string TacGia { get; set; }
        public int? DonGia { get; set; }
        public string MaTheLoai { get; set; }

        public virtual TblTheLoai1 MaTheLoaiNavigation { get; set; }
    }
}
