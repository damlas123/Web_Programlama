using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class Dersler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
