using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OgrenciController : Controller
    {
        static List<Ogrenci> students = new List<Ogrenci>
       //Hİçbir şey yazılmadığında da htppget alınır htppget alınır
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(string Ad, string Numara)
        {
            return Ad + " " + Numara;
        }

        public IActionResult Kaydet(Ogrenci ogrenci)
        {
            string txtinfo = "Burası öğrenci kontrollorindan kaydet actionı.";
            return View(ogrenci);
        }
        public IActionResult OgrenciListele()
        {
            return View();
        }
        public IActionResult OgrenciEkle( Ogrenci ogrenci)
        {
            students.Add(ogrenci);
            return RedirectToAction("OgrenciListele", "Ogrenci");
        }
    }
}
