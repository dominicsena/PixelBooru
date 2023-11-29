using Microsoft.AspNetCore.Mvc;

namespace pixelBooru.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
