using Microsoft.AspNetCore.Mvc;
using pixelBooru.Models;

namespace pixelBooru.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }


    }
}