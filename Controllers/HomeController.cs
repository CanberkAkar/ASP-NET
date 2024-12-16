using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string Title = "film 1";
            string Desc = "açıklama 1";

            string Director = "director";

            string[] Players = { "player1", "player2" };
            string ImageUrl = "godfather.jpg";

            var m = new Movie();
            m.Title = Title;
            m.Desc = Desc;
            m.Director = Director;
            m.Players = Players;
            m.ImageUrl = ImageUrl;

            return View(m);
        }
        public IActionResult About()
        {
            var genreListed = new List<Genre>()
            {
                new Genre{Name="Macera"},
                new Genre{Name="Savaş"},
                new Genre{Name="Romantik"}

            };

            return View(genreListed);
        }
    }
}
