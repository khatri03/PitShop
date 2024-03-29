﻿using PitShop.Infrastructure.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Commands
{
    public class FinishMaintenanceJob : Command
    {
        public readonly Guid JobId;
        public readonly DateTime StartTime;
        public readonly DateTime EndTime;
        public readonly string Notes;

        public FinishMaintenanceJob(Guid messageId, Guid jobId, DateTime startTime, DateTime endTime, string notes) :
            base(messageId)
        {
            JobId = jobId;
            StartTime = startTime;
            EndTime = endTime;
            Notes = notes;
        }
    }
}
