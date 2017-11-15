namespace VegaSystem.Persistence.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VegaSystem.Core;
    using VegaSystem.Entities;

    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);

        Task<IEnumerable<Vehicle>> GetVehicles(VehicleQuery filter);

        void Add(Vehicle vehicle);

        void Remove(Vehicle vehicle);
    }
}