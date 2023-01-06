using System;
using System.Collections.Generic;

#nullable disable

namespace luyen_tap.Models
{
    public partial class TblTheLoai1
    {
        public TblTheLoai1()
        {
            TblTaiLieus = new HashSet<TblTaiLieu>();
        }

        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        public virtual ICollection<TblTaiLieu> TblTaiLieus { get; set; }
    }
}
