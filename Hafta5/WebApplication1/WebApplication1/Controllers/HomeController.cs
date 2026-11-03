using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult FirstRequest()
        {
            ViewBag.VBmesaj = "Bu mesaj Viewbag ile gönderildi";
            ViewData["VDmesaj"] = "Bu mesajda Viewdata ile gönderildi";
            TempData["TDmesaj"] = "Bu mesaj Tempdate ile gönderildi";
            TempData["Sayi"] = 6;
            //View data ile temp data için tip dönüşümü yapmamız gerekiyor.
            //Temp date yönlendirildikten sonra bir sonraki requestte kullanılabilir. View data ise sadece o anki requestte kullanılabilir.  

            return RedirectToAction("SecondRequest");
        }
        public IActionResult SecondRequest()
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
