using PitShop.Infrastructure.Messaging;
using PitShop.Infrastructure.Messaging.Abstraction;
using PitShop.WorkshopManagementAPI.Commands;
using PitShop.WorkshopManagementAPI.Domain;
using PitShop.WorkshopManagementAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.CommandHandlers
{
    public class FinishMaintenanceJobCommandHandler : IFinishMaintenanceJobCommandHandler
    {
        IMessagePublisher _messagePublisher;
        IWorkshopPlanningRepository _planningRepo;

        public FinishMaintenanceJobCommandHandler(IMessagePublisher messagePublisher, IWorkshopPlanningRepository planningRepo)
        {
            _messagePublisher = messagePublisher;
            _planningRepo = planningRepo;
        }

        public async Task<WorkshopPlanning> HandleCommandAsync(DateTime planningDate, FinishMaintenanceJob command)
        {
            // get planning
            WorkshopPlanning planning = await _planningRepo.GetWorkshopPlanningAsync(planningDate);
            if (planning == null)
            {
                return null;
            }

            // handle command
            planning.FinishMaintenanceJob(command);

            // persist
            IEnumerable<Event> events = planning.GetEvents();
            await _planningRepo.SaveWorkshopPlanningAsync(
                planning.Id, planning.OriginalVersion, planning.Version, events);

            // publish event
            foreach (var e in events)
            {
                await _messagePublisher.PublishMessageAsync(e.MessageType, e, "");
            }

            // return result
            return planning;
        }
    }
}
