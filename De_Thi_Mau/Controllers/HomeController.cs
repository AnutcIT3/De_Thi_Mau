using AspNetCoreGeneratedDocument;
using De_Thi_Mau.Models;
using Microsoft.AspNetCore.Mvc;
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
