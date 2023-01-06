using System;
using System.Collections.Generic;

namespace QLSanPham.Models;

public partial class Loai
{
    public int Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; } = new List<SanPham>();
}
