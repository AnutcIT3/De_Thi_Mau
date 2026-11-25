using AspNetCoreGeneratedDocument;
using De_Thi_Mau.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace De_Thi_Mau.Controllers
{
    public class HomeController : Controller
    {
        public readonly QlhangHoaContext _context;
        public HomeController (QlhangHoaContext Context)
        {
            _context = Context;
        }
        public IActionResult Index()
        {
            var hangHoas = _context.HangHoas
                                   .Where(h => h.Gia >= 100)
                                   .ToList();
            return View(hangHoas);
        }

        public IActionResult FilterByLoai(int maLoai)
        {
            var hangHoas = _context.HangHoas
                                   .Where(h => h.MaLoai == maLoai && h.Gia >= 100)
                                   .ToList() ;
            return PartialView("_HangHoaListPartial",hangHoas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                _context.HangHoas.Add(hangHoa);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hangHoa);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
