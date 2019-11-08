using PitShop.VehicleManagement.Commands;
using PitShop.VehicleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.VehicleManagement.Mappers
{
    public static class Mappers
    {
        public static Vehicle MapToVehicle(this RegisterVehicle command) => new Vehicle
        {
            LicenseNumber = command.LicenseNumber,
            Brand = command.Brand,
            Type = command.Type,
            OwnerId = command.OwnerId
        };
    }
}
