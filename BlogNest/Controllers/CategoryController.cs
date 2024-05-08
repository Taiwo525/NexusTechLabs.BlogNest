using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
