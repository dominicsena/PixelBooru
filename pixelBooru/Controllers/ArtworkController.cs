using Microsoft.AspNetCore.Mvc;
using pixelBooru.Models;

namespace pixelBooru.Controllers
{
    public class ArtworkController : Controller
    {
        public IActionResult Index() {
            return View();

        }


    }
}