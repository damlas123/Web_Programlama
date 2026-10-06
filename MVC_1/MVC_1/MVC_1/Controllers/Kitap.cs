using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Listele()
        {
            return View();
        }
        public IActionResult Ekle()
        {
            return View();
        }

        //[HttpPost] burada hiçbir şey eklenmese GET olur. 
        /*public IActionResult Ekle2()
        {
            return View();
        }
        */
    }
}
