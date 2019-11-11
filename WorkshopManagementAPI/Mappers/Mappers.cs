using PitShop.WorkshopManagementAPI.Commands;
using PitShop.WorkshopManagementAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Mappers
{
    public static class Mappers
    {
        public static MaintenanceJobPlanned MapToMaintenanceJobPlanned(this PlanMaintenanceJob source) => new MaintenanceJobPlanned(
            Guid.NewGuid(),
            source.JobId,
            source.StartTime,
            source.EndTime,
            source.CustomerInfo,
            source.VehicleInfo,
            source.Description
        );

        public static MaintenanceJobFinished MapToMaintenanceJobFinished(this FinishMaintenanceJob source) => new MaintenanceJobFinished
        (
            Guid.NewGuid(),
            source.JobId,
            source.StartTime,
            source.EndTime,
            source.Notes
        );
    }
}
