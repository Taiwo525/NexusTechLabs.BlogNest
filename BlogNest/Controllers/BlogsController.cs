using BlogNest.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IPostRepo _postRepo;
        public BlogsController(IPostRepo postRepo)
        {
            _postRepo = postRepo;
        }
        [HttpGet]
        public async Task<IActionResult> Index(string urlHandle)
        {
            var post = await _postRepo.GetPostByUrlHandleAsync(urlHandle);
            return View(post);
        }
    }
}
