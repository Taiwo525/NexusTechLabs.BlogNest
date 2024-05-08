using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
