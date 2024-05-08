using BlogNest.Core.Repositories;
using BlogNest.Models;
using BlogNest.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;

namespace BlogNest.Controllers
{
    public class AdminPostController : Controller
    {
        private readonly IPostRepo _postRepository;
        private readonly ITagRepo _tagRepo;

        public AdminPostController(IPostRepo postRepository, ITagRepo tagRepo)
        {
            _postRepository = postRepository;
            _tagRepo = tagRepo;
        }

        // GET: Post
        public async Task<IActionResult> Index()
        {
            var posts = await _postRepository.GetAllPostsAsync();
            return View(posts);
        }

        // GET: Post/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var post = await _postRepository.GetPostByIdAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Post/Create
        public async Task<IActionResult> Create()
        { 
            var tags = await _tagRepo.GetAllAsync();
            var model = new AddPostRequest()
            {
                Tags = tags.Select(x => new SelectListItem { Text = x.DisplayName, Value = x.Id.ToString() })
            };
            return View(model);
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddPostRequest post)
        {
            var result = new Post
            {
                Heading = post.Heading,
                PageTitle = post.PageTitle,
                Content = post.Content,
                ShortDescription = post.ShortDescription,
                FeaturedImageUrl = post.FeaturedImageUrl,
                UrlHandle = post.UrlHandle,
                PublishedDate = post.PublishedDate,
                Author = post.Author,
                Visible = post.Visible,
            };
            var selectedTags = new List<Tag>();
            foreach(var selectedTagId in post.SelectedTags)
            {
                 var selectedTagIdGuid = Guid.Parse(selectedTagId);
                var tagExist = await _tagRepo.GetByIdAsync(selectedTagIdGuid);
                if (tagExist != null)
                {
                    selectedTags.Add(tagExist);
                };
            }
            result.Tags = selectedTags;
           
               await _postRepository.AddPostAsync(result);
                return RedirectToAction(nameof(Index));
          
        }

        // GET: Post/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var post = await _postRepository.GetPostByIdAsync(id);
            var tag = await _tagRepo.GetAllAsync();
            

            if (post != null)
            {
                var model = new EditPostRequest
                {
                    Id = post.Id,
                    Heading = post.Heading,
                    PageTitle = post.PageTitle,
                    Content = post.Content,
                    ShortDescription = post.ShortDescription,
                    FeaturedImageUrl = post.FeaturedImageUrl,
                    UrlHandle = post.UrlHandle,
                    PublishedDate = post.PublishedDate,
                    Author = post.Author,
                    Visible = post.Visible,
                    Tags = tag.Select(x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    }),
                    SelectedTags = post.Tags.Select(x => x.Id.ToString()).ToArray()
                };
                return View(model);
            }

            return View(null);
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditPostRequest editPost)
        {
            var result = new Post
            {
                Id = editPost.Id,
                Heading = editPost.Heading,
                PageTitle = editPost.PageTitle,
                Content = editPost.Content,
                ShortDescription = editPost.ShortDescription,
                FeaturedImageUrl = editPost.FeaturedImageUrl,
                UrlHandle = editPost.UrlHandle,
                PublishedDate = editPost.PublishedDate,
                Author = editPost.Author,
                Visible = editPost.Visible,
            };
             var selectedTags = new List<Tag>();
            foreach (var selectedTag in editPost.SelectedTags)
                if(Guid.TryParse(selectedTag, out var tag))
                {
                    var foundTag = await _tagRepo.GetByIdAsync(tag);
                    if (foundTag != null)
                    {
                        selectedTags.Add(foundTag);
                    }
                }
            result.Tags = selectedTags;
            var updatedBlog = await _postRepository.UpdatePostAsync(result);
            if (updatedBlog != null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Edit));
        }

        // GET: Post/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _postRepository.DeletePostAsync(id);

            if (deleted != null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
          await _postRepository.DeletePostAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
