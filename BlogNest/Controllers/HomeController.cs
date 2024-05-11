using BlogNest.Core.Repositories;
using BlogNest.Models;
using BlogNest.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogNest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostRepo repo;
        private readonly ITagRepo tag;

        public HomeController(ILogger<HomeController> logger, IPostRepo repo, ITagRepo tag)
        {
            _logger = logger;
            this.repo = repo;
            this.tag = tag;
        }

        public async Task<IActionResult> Index()
        {
            var po = await repo.GetAllPostsAsync();
            var ta = await tag.GetAllAsync();

            var result = new HomeModel
            {
                Posts = po,
                Tags = ta
            };

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}