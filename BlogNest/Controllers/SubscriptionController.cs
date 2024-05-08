using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Controllers
{
    public class SubscriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
