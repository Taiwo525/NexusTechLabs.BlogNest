using BlogNest.Core.Repositories;
using BlogNest.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogNest.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IPostRepo _postRepo;
        private readonly ILikeRepo like;

        public BlogsController(IPostRepo postRepo, ILikeRepo like)
        {
            _postRepo = postRepo;
            this.like = like;
        }
        [HttpGet]
        public async Task<IActionResult> Index(string urlHandle)
        {
            var post = await _postRepo.GetPostByUrlHandleAsync(urlHandle);

            var detailsModel = new DetailsViewModel();
                if (post != null)
            {
                var totalLikes = await like.GetLikesAsync(post.Id);
                detailsModel = new DetailsViewModel
                {
                    Id = post.Id,
                    Content = post.Content,
                    PageTitle = post.PageTitle,
                    FeaturedImageUrl = post.FeaturedImageUrl,
                    Heading = post.Heading,
                    Author = post.Author,
                    PublishedDate = post.PublishedDate,
                    ShortDescription = post.ShortDescription,
                    UrlHandle = post.UrlHandle,
                    Visible = post.Visible,
                    Tags = post.Tags,
                    TotalLike = totalLikes
                };
            }
            return View(detailsModel);
        }
    }
}
