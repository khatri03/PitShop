﻿using Microsoft.Extensions.Configuration;
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
    public class VehicleManagementAPI : IVehicleManagementAPI
    {
        private IVehicleManagementAPI _restClient;

        public VehicleManagementAPI(IConfiguration config, HttpClient httpClient)
        {
            string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("VehicleManagementAPI");
            httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
            _restClient = RestService.For<IVehicleManagementAPI>(httpClient);
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

        public async Task RegisterVehicle(RegisterVehicleCommand command)
        {
            await _restClient.RegisterVehicle(command);
        }
    }
}
