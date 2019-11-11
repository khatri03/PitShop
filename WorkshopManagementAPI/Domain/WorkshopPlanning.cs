﻿using PitShop.Infrastructure.Messaging;
using PitShop.WorkshopManagementAPI.Commands;
using PitShop.WorkshopManagementAPI.Domain.Core;
using PitShop.WorkshopManagementAPI.Domain.Exceptions;
using PitShop.WorkshopManagementAPI.Events;
using PitShop.WorkshopManagementAPI.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Domain
{
    public class WorkshopPlanning : AggregateRoot<string>
    {
        /// <summary>
        /// The list of maintenance-jobs for this day. 
        /// </summary>
        public List<MaintenanceJob> Jobs { get; private set; }

        public WorkshopPlanning(DateTime date) : base(date.ToString("yyyy-MM-dd")) { }

        public WorkshopPlanning(DateTime date, IEnumerable<Event> events) : base(date.ToString("yyyy-MM-dd"), events) { }

        /// <summary>
        /// Creates a new instance of a workshop-planning for the specified date.
        /// </summary>
        /// <param name="date">The date to create the planning for.</param>
        public static WorkshopPlanning Create(DateTime date)
        {
            WorkshopPlanning planning = new WorkshopPlanning(date);
            WorkshopPlanningCreated e = new WorkshopPlanningCreated(Guid.NewGuid(), date);
            planning.RaiseEvent(e);
            return planning;
        }

        public void PlanMaintenanceJob(PlanMaintenanceJob command)
        {
            // check business rules
            this.PlannedMaintenanceJobShouldFallWithinOneBusinessDay(command);
            this.NumberOfParallelMaintenanceJobsMustNotExceedAvailableWorkStations(command);
            this.NumberOfParallelMaintenanceJobsOnAVehicleIsOne(command);

            // handle event
            MaintenanceJobPlanned e = command.MapToMaintenanceJobPlanned();
            RaiseEvent(e);
        }

        public void FinishMaintenanceJob(FinishMaintenanceJob command)
        {
            // find job
            MaintenanceJob job = Jobs.FirstOrDefault(j => j.Id == command.JobId);
            if (job == null)
            {
                throw new MaintenanceJobNotFoundException($"Maintenance job with id {command.JobId} found.");
            }

            // check business rules
            job.FinishedMaintenanceJobCanNotBeFinished();

            // handle event
            MaintenanceJobFinished e = command.MapToMaintenanceJobFinished();
            RaiseEvent(e);
        }

        /// <summary>
        /// Handles an event and updates the aggregate version.
        /// </summary>
        /// <remarks>Caution: this handles is also called while replaying events to restore state.
        /// So, do not execute any checks that couold fail or introduce any side-effects in this handler.</remarks>
        protected override void HandleEvent(Event eventToHandle)
        {
            switch (eventToHandle)
            {
                case WorkshopPlanningCreated e:
                    Handle(e);
                    break;
                case MaintenanceJobPlanned e:
                    Handle(e);
                    break;
                case MaintenanceJobFinished e:
                    Handle(e);
                    break;
                default:
                    throw new InvalidOperationException("Unknown event-type specified for replay.");
            }
        }

        private void Handle(WorkshopPlanningCreated e)
        {
            Jobs = new List<MaintenanceJob>();
        }

        private void Handle(MaintenanceJobPlanned e)
        {
            MaintenanceJob job = new MaintenanceJob();
            Customer customer = new Customer(e.CustomerInfo.Id, e.CustomerInfo.Name, e.CustomerInfo.TelephoneNumber);
            Vehicle vehicle = new Vehicle(e.VehicleInfo.LicenseNumber, e.VehicleInfo.Brand, e.VehicleInfo.Type, customer.Id);
            job.Plan(e.JobId, e.StartTime, e.EndTime, vehicle, customer, e.Description);
            Jobs.Add(job);
        }

        private void Handle(MaintenanceJobFinished e)
        {
            MaintenanceJob job = Jobs.FirstOrDefault(j => j.Id == e.JobId);
            job.Finish(e.StartTime, e.EndTime, e.Notes);
        }
    }
}
