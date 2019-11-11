using Microsoft.Extensions.Configuration;
using PitShop.Web.Commands;
using PitShop.Web.Microservices.Abstraction;
using PitShop.Web.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PitShop.Web.Microservices
{
    public class WorkshopManagementAPI : IWorkshopManagementAPI
    {
        private IWorkshopManagementAPI _restClient;

        public WorkshopManagementAPI(IConfiguration config, HttpClient httpClient)
        {
            string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("WorkshopManagementAPI");
            httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
            _restClient = RestService.For<IWorkshopManagementAPI>(httpClient);
        }

        public async Task<WorkshopPlanning> GetWorkshopPlanning(string planningDate)
        {
            try
            {
                return await _restClient.GetWorkshopPlanning(planningDate);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<MaintenanceJob> GetMaintenanceJob(string planningDate, string jobId)
        {
            try
            {
                return await _restClient.GetMaintenanceJob(planningDate, jobId);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task RegisterPlanning(string planningDate, RegisterPlanningCommand cmd)
        {
            await _restClient.RegisterPlanning(planningDate, cmd);
        }

        public async Task PlanMaintenanceJob(string planningDate, PlanMaintenanceJobCommand cmd)
        {
            await _restClient.PlanMaintenanceJob(planningDate, cmd);
        }

        public async Task FinishMaintenanceJob(string planningDate, string jobId, FinishMaintenanceJobCommand cmd)
        {
            await _restClient.FinishMaintenanceJob(planningDate, jobId, cmd);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _restClient.GetCustomers();
        }

        public async Task<Customer> GetCustomerById(string id)
        {
            try
            {
                return await _restClient.GetCustomerById(id);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            return await _restClient.GetVehicles();
        }

        public async Task<Vehicle> GetVehicleByLicenseNumber([AliasAs("id")] string licenseNumber)
        {
            try
            {
                return await _restClient.GetVehicleByLicenseNumber(licenseNumber);
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
