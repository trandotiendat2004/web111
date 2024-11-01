using System;
using System.Collections.Generic;

namespace web111.Models;

public partial class Tuser
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string LoaiUser { get; set; } = null!;

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
