using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult List()
        {
            string movies = "Test";
            string desc = "Desc";
            string director = "Director";
            string[] actors = { "actor1", "actor2" };
            ViewBag.Movies = movies;
            ViewBag.Desc = desc;
            ViewBag.Director = director;
            ViewBag.Actors = actors;

            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
