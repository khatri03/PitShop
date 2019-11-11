using PitShop.WorkshopManagementAPI.Repositories.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetVehiclesAsync();
        Task<Vehicle> GetVehicleAsync(string licenseNumber);
    }
}
