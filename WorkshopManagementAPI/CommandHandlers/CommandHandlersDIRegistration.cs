using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.CommandHandlers
{
    public static class CommandHandlersDIRegistration
    {
        public static void AddCommandHandlers(this IServiceCollection services)
        {
            services.AddTransient<IPlanMaintenanceJobCommandHandler, PlanMaintenanceJobCommandHandler>();
            services.AddTransient<IFinishMaintenanceJobCommandHandler, FinishMaintenanceJobCommandHandler>();
        }
    }
}
