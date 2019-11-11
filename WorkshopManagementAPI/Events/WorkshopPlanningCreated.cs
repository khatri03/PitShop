using PitShop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Events
{
    public class WorkshopPlanningCreated : Event
    {
        public readonly DateTime Date;

        public WorkshopPlanningCreated(Guid messageId, DateTime date) : base(messageId)
        {
            Date = date;
        }
    }
}
