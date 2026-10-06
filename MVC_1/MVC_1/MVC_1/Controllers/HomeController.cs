using Microsoft.AspNetCore.Mvc;
using MVC_1.Models;
using System.Diagnostics;

namespace MVC_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //ilk istek geldiğinde çalışacak olan action methodu 
        {
            return View();
        }
        public String Index2()
        {
            return "Index2 action methodu çalıştı";
        }
        
        public String Index3(int id)
        {
            return "Index3 action methodu çalıştı : ID" + id;
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
