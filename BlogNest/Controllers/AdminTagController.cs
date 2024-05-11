using BlogNest.Core.Repositories;
using BlogNest.Data;
using BlogNest.Models;
using BlogNest.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BlogNest.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminTagController : Controller
    {
        private readonly ITagRepo _blog;

        public AdminTagController(ITagRepo blog) 
        {
            _blog = blog;
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public async Task<IActionResult> AddAsync(AddTagRequest request)
        {
            if (ModelState.IsValid)
            {
                var tag = new Tag
                {
                    Name = request.Name,
                    DisplayName = request.DisplayName
                };

               await _blog.AddTagAsync(tag);
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(request);
        }
    
        [HttpGet]
        public async Task<IActionResult> Index() 
        {
            var tags = await _blog.GetAllAsync();
            return View(tags);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id) 
        {
            var result = await _blog.GetByIdAsync(id);
            if (result != null) 
            {
                var tag = new EditTagRequest
                {
                    Id = result.Id,
                    Name = result.Name,
                    DisplayName = result.DisplayName
                };
                return View(tag);
            }
            return View(null);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Tag request) 
        {
            var result = new Tag
            {
                Id = request.Id,
                Name = request.Name,
                DisplayName = request.DisplayName
            };
            var updated = await _blog.UpdateTagAsync(result);
            if (updated != null)
            {
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction(nameof(Index));
            }       
            TempData["msg"] = "Error has occured on server side";
            return View(request);
        }
        
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _blog.DeleteTagAsync(id);

            if (deleted != null)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
