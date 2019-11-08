using PitShop.Web.Commands;
using PitShop.Web.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Microservices.Abstraction
{
    public interface ICustomerManagementAPI
    {
        [Get("/customers")]
        Task<List<Customer>> GetCustomers();

        [Get("/customers/{id}")]
        Task<Customer> GetCustomerById([AliasAs("id")] string customerId);

        [Post("/customers")]
        Task RegisterCustomer(RegisterCustomer command);
    }
}
