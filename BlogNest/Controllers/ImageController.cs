using BlogNest.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogNest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        public readonly IImageRepo _image;
        public ImageController(IImageRepo image)
        {
            _image = image;
        }

        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
           var imageUrl = await _image.UploadImageAsync(file);
            if (imageUrl == null)
            {
                return Problem("There is no imageUrl", null, (int)HttpStatusCode.InternalServerError);
            }
            return new JsonResult(new { Link = imageUrl });
        }
    }
}
