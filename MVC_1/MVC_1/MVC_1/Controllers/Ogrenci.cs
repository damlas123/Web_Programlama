using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
