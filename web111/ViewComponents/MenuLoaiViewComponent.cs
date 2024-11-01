﻿using Microsoft.AspNetCore.Mvc;
using web111.Models;
using web111.ViewModels;
namespace web111.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly WebContext db;
        public MenuLoaiViewComponent(WebContext context) => db = context;
        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);
            return View(data);
        }
    }
}
