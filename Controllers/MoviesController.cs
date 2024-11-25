using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
