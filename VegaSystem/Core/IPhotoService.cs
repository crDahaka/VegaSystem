namespace VegaSystem.Core
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using VegaSystem.Core.Entities;
    using VegaSystem.Entities;

    public interface IPhotoService
    {
        Task<Photo> UploadPhoto(Vehicle vehicle, IFormFile file, string uploadFolderPath);
    }
}