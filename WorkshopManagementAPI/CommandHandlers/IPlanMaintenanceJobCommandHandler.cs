﻿using PitShop.WorkshopManagementAPI.Commands;
using PitShop.WorkshopManagementAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.CommandHandlers
{
    public interface IPlanMaintenanceJobCommandHandler
    {
        Task<WorkshopPlanning> HandleCommandAsync(DateTime planningDate, PlanMaintenanceJob command);
    }
}