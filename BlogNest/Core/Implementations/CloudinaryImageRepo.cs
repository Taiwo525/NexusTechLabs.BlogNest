using BlogNest.Core.Repositories;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace BlogNest.Core.Implementations
{
    public class CloudinaryImageRepo : IImageRepo
    {
        public readonly IConfiguration configuration;
        private readonly Account account;
        public CloudinaryImageRepo(IConfiguration configuration)
        {
            Configuration = configuration;
            account = new Account(
                configuration.GetSection("Cloudinay")["CloudName"],
                configuration.GetSection("Cloudinay")["ApiKey"],
                configuration.GetSection("Cloudinay")["ApiSecret"]);
        }

        public IConfiguration Configuration { get; }

        public async Task<string> UploadImageAsync(IFormFile file)
        {
            var client = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName, file.OpenReadStream()),
                DisplayName = file.FileName
            };
            var uploadResult = await client.UploadAsync(uploadParams);
            if (uploadResult != null && uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return uploadResult.SecureUrl.ToString();
            }
            return null;
        }
    }
}
