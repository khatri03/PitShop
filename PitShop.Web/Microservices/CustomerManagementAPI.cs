using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using System.Net;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System;
using PitShop.Web.Microservices.Abstraction;
using PitShop.Web.Models;
using PitShop.Web.Commands;

namespace PitShop.Web.Microservices
{
    public class CustomerManagementAPI : ICustomerManagementAPI
    {
        private ICustomerManagementAPI _restClient;

        public CustomerManagementAPI(IConfiguration config, HttpClient httpClient)
        {
            string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("CustomerManagementAPI");
            httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
            _restClient = RestService.For<ICustomerManagementAPI>(httpClient);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _restClient.GetCustomers();
        }

        public async Task<Customer> GetCustomerById([AliasAs("id")] string customerId)
        {
            try
            {
                return await _restClient.GetCustomerById(customerId);
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

        public async Task RegisterCustomer(RegisterCustomer command)
        {
            await _restClient.RegisterCustomer(command);
        }
    }
}
