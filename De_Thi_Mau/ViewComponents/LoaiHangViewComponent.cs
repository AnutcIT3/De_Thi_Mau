using Microsoft.AspNetCore.Mvc;
using De_Thi_Mau.Models;

namespace De_Thi_Mau.ViewComponents
{
    public class LoaiHangViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;

        public LoaiHangViewComponent(QlhangHoaContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string viewName = "Default", int? selectedId = null)
        {
            ViewBag.SelectedId = selectedId;
            var loaiHangs = _context.LoaiHangs.ToList();
            return View(viewName, loaiHangs);
        }
    }
}