using Microsoft.AspNetCore.Mvc;
using web111.Models;
using web111.ViewModels;

namespace web111.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly WebContext db;

        public HangHoaController(WebContext context) {
            db = context;  
        }
        public IActionResult Index(int? loai)
        {
            var hanghoas = db.HangHoas.AsQueryable();
            if (loai.HasValue)
            {
                hanghoas = hanghoas.Where(p => p.MaLoai == loai.Value);
            }
            var result = hanghoas.Select(p => new HangHoaVM
            {
                TenLoai = p.MaLoaiNavigation.TenLoai,
                MaHh = p.MaHh,
                TenHH = p.TenHh,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTaDonVi
            });
            return View(result);
        }
        public IActionResult Search(string? query)
        {
            var hanghoas = db.HangHoas.AsQueryable();
            if (query != null)
            {
                hanghoas = hanghoas.Where(p => p.TenHh.Contains(query));
            }
            var result = hanghoas.Select(p => new HangHoaVM
            {
                TenLoai = p.MaLoaiNavigation.TenLoai,
                MaHh = p.MaHh,
                TenHH = p.TenHh,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTaDonVi
            });
            return View(result);
        }
    }
}
