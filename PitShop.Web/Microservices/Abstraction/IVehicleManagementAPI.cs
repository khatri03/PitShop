using PitShop.Web.Commands;
using PitShop.Web.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Microservices.Abstraction
{
    public interface IVehicleManagementAPI
    {
        [Get("/vehicles")]
        Task<List<Vehicle>> GetVehicles();

        [Get("/vehicles/{id}")]
        Task<Vehicle> GetVehicleByLicenseNumber([AliasAs("id")] string licenseNumber);

        [Post("/vehicles")]
        Task RegisterVehicle(RegisterVehicleCommand command);
    }
}
