using PitShop.WorkshopManagementAPI.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Domain
{
    public class Customer : Entity<string>
    {
        public string Name { get; private set; }
        public string TelephoneNumber { get; private set; }

        public Customer(string customerId, string name, string telephoneNumber) : base(customerId)
        {
            Name = name;
            TelephoneNumber = telephoneNumber;
        }
    }
}
