using PitShop.Web.Commands;
using PitShop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Mappers
{
    public static class Mappers
    {
        public static RegisterCustomer MapToRegisterCustomer(this CustomerManagementNewViewModel source) => new RegisterCustomer
        (
            Guid.NewGuid(),
            Guid.NewGuid().ToString("N"),
            source.Customer.Name,
            source.Customer.Address,
            source.Customer.PostalCode,
            source.Customer.City,
            source.Customer.TelephoneNumber,
            source.Customer.EmailAddress
        );

        public static RegisterVehicleCommand MapToRegisterVehicle(this VehicleManagementNewViewModel source) => new RegisterVehicleCommand(
            Guid.NewGuid(),
            source.Vehicle.LicenseNumber,
            source.Vehicle.Brand,
            source.Vehicle.Type,
            source.SelectedCustomerId
        );
    }
}
