using PitShop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Commands
{
    public class RegisterPlanningCommand : Command
    {
        public readonly DateTime PlanningDate;

        public RegisterPlanningCommand(Guid messageId, DateTime planningDate) : base(messageId)
        {
            PlanningDate = planningDate;
        }
    }
}
