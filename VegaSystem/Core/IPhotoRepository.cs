namespace VegaSystem.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VegaSystem.Core.Entities;
    
    public interface IPhotoRepository
    {
         Task<IEnumerable<Photo>> GetPhotos(int vehicleId);
    }
}