using Microsoft.AspNetCore.Mvc;

namespace Uygulama_1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
