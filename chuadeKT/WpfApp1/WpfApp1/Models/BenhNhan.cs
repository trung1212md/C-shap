using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp1.Models
{
    public partial class benhnhan
    {
        public int MaBn { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int? SoNgayNamVien { get; set; }
        public double? VienPhi { get; set; }
        public int? MaKhoa { get; set; }

        public virtual Khoa MaKhoaNavigation { get; set; }
    }
}
