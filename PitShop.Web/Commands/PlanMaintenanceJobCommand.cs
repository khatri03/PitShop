using PitShop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Commands
{
    public class PlanMaintenanceJobCommand : Command
    {
        public readonly Guid JobId;
        public readonly DateTime StartTime;
        public readonly DateTime EndTime;
        public readonly (string Id, string Name, string TelephoneNumber) CustomerInfo;
        public readonly (string LicenseNumber, string Brand, string Type) VehicleInfo;
        public readonly string Description;

        public PlanMaintenanceJobCommand(Guid messageId, Guid jobId, DateTime startTime, DateTime endTime,
            (string Id, string Name, string TelephoneNumber) customerInfo,
            (string LicenseNumber, string Brand, string Type) vehicleInfo,
            string description) : base(messageId)
        {
            JobId = jobId;
            StartTime = startTime;
            EndTime = endTime;
            CustomerInfo = customerInfo;
            VehicleInfo = vehicleInfo;
            Description = description;
        }
    }
}
