using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
