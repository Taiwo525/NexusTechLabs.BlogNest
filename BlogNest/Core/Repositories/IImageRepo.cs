namespace BlogNest.Core.Repositories
{
    public interface IImageRepo
    {
        Task<string> UploadImageAsync(IFormFile file);
    }
}
