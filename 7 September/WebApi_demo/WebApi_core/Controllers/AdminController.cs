using Microsoft.AspNetCore.Mvc;

namespace WebApi_core.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult ADashboard()
        {
            return View();
        }
    }
}
