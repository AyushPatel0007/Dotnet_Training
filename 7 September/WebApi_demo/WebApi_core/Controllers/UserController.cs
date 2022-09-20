using Microsoft.AspNetCore.Mvc;

namespace WebApi_core.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
