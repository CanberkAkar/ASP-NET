using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(){
            var genreListed = new List<Genre>()
            {
                new Genre{Name="Macera"},
                new Genre{Name="Savaş"},
                new Genre{Name="Romantik"}

            };
            return View (genreListed);
        }
    }
}
