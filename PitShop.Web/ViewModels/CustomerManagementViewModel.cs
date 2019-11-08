using PitShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.ViewModels
{
    public class CustomerManagementViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}
