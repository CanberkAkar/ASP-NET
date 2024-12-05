using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult List()
        {
            //layout sayfalara göre spesifik olarak da düzenlenir.
            var movieListed = new List<Movie>()
            {
                new Movie {
                    Title="film 1",
                    Desc="açıklama 1",
                    Director="director",
                    Players= new String[]{"player1","player2"},
                    ImageUrl="godfather.jpg"
                }
                
            };
            return View("Movies",movieListed);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
