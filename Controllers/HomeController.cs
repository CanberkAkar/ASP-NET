using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult About()
        {
            return View();
        }
    }
}