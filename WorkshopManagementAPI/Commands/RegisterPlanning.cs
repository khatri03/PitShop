using PitShop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Commands
{
    public class RegisterPlanning : Command
    {
        public readonly DateTime PlanningDate;

        public RegisterPlanning(Guid messageId, DateTime planningDate) : base(messageId)
        {
            PlanningDate = planningDate;
        }
    }
}
