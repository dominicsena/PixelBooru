using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace pixelBooru.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        //GET /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
