using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp1.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            BenhNhans = new HashSet<benhnhan>();
        }

        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public virtual ICollection<benhnhan> BenhNhans { get; set; }
    }
}
