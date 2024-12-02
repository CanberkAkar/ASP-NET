using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult List()
        {
            var movie = new Movie();
            string movies = "Test";
            string desc = "Desc";
            string director = "Director";
            string[] actors = { "actor1", "actor2" };
            
            movie.Title = movies;       // movie nesnesine Title atanıyor
            movie.Desc = desc;          // movie nesnesine Desc atanıyor
            movie.Director = director;  // movie nesnesine Director atanıyor
            movie.Players = actors;     // Hatalı olan movies.Players yerine movie.Players yazıldı

            // Movie modelini View'e gönderin
            return View(movie);
        } 

        public IActionResult Detail()
        {
            return View();
        }
    }
}
