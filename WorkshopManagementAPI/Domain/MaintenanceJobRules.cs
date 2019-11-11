using PitShop.WorkshopManagementAPI.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Domain
{
    public static class MaintenanceJobRules
    {
        public static void FinishedMaintenanceJobCanNotBeFinished(this MaintenanceJob job)
        {
            if (job.Status == "Completed")
            {
                throw new BusinessRuleViolationException($"An already finished job can not be finished.");
            }
        }
    }
}
