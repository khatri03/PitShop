using PitShop.Web.Commands;
using PitShop.Web.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Microservices.Abstraction
{
    public interface IWorkshopManagementAPI
    {
        [Get("/workshopplanning/{planningDate}")]
        Task<WorkshopPlanning> GetWorkshopPlanning(string planningDate);

        [Get("/workshopplanning/{planningDate}/jobs/{jobId}")]
        Task<MaintenanceJob> GetMaintenanceJob(string planningDate, string jobId);

        [Post("/workshopplanning/{planningDate}")]
        Task RegisterPlanning(string planningDate, RegisterPlanningCommand cmd);

        [Post("/workshopplanning/{planningDate}/jobs")]
        Task PlanMaintenanceJob(string planningDate, PlanMaintenanceJobCommand cmd);

        [Put("/workshopplanning/{planningDate}/jobs/{jobId}/finish")]
        Task FinishMaintenanceJob(string planningDate, string jobId, FinishMaintenanceJobCommand cmd);

        [Get("/refdata/customers")]
        Task<List<Customer>> GetCustomers();

        [Get("/refdata/customers/{id}")]
        Task<Customer> GetCustomerById(string id);

        [Get("/refdata/vehicles")]
        Task<List<Vehicle>> GetVehicles();

        [Get("/refdata/vehicles/{id}")]
        Task<Vehicle> GetVehicleByLicenseNumber([AliasAs("id")] string licenseNumber);
    }
}
