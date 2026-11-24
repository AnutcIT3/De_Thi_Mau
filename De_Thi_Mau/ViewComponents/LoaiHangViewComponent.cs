using Microsoft.AspNetCore.Mvc;
using De_Thi_Mau.Models;
namespace De_Thi_Mau.ViewComponents
{
    public class LoaiHangViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;
        public LoaiHangViewComponent (QlhangHoaContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync ()
        {
            var loaiHoangs = _context.LoaiHangs.ToList();
            return View(loaiHoangs);
        }
    }
}
