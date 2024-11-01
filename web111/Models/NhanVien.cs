using System;
using System.Collections.Generic;

namespace web111.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? MatKhau { get; set; }

    public string? Username { get; set; }

    public virtual Tuser? UsernameNavigation { get; set; }
}
