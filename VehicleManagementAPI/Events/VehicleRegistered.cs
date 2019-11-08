using PitShop.Infrastructure.Messaging;
using PitShop.VehicleManagement.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.VehicleManagement.Events
{
    public class VehicleRegistered : Event
    {
        public readonly string LicenseNumber;
        public readonly string Brand;
        public readonly string Type;
        public readonly string OwnerId;

        public VehicleRegistered(Guid messageId, string licenseNumber, string brand, string type, string ownerId) :
            base(messageId)
        {
            LicenseNumber = licenseNumber;
            Brand = brand;
            Type = type;
            OwnerId = ownerId;
        }

        public static VehicleRegistered FromCommand(RegisterVehicle command)
        {
            return new VehicleRegistered(
                Guid.NewGuid(),
                command.LicenseNumber,
                command.Brand,
                command.Type,
                command.OwnerId
            );
        }
    }
}
