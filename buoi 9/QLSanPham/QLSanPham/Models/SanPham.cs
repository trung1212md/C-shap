using System;
using System.Collections.Generic;

namespace QLSanPham.Models;

public partial class SanPham
{
    public int Ma { get; set; }

    public string? Ten { get; set; }

    public int? SoLuong { get; set; }

    public decimal? DonGia { get; set; }

    public int? MaLoai { get; set; }

    public virtual Loai? MaLoaiNavigation { get; set; }
    public SanPham() { }
    public SanPham(string? ten, int? soLuong, decimal? donGia, int? maLoai)
    {
        Ten = ten;
        SoLuong = soLuong;
        DonGia = donGia;
        MaLoai = maLoai;
    }
}
