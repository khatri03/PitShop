using PitShop.WorkshopManagementAPI.Commands;
using PitShop.WorkshopManagementAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.CommandHandlers
{
    public interface IFinishMaintenanceJobCommandHandler
    {
        Task<WorkshopPlanning> HandleCommandAsync(DateTime planningDate, FinishMaintenanceJob command);
    }
}
