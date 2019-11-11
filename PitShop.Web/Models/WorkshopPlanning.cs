using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Models
{
    public class WorkshopPlanning
    {
        public DateTime Date { get; set; }
        public List<MaintenanceJob> Jobs { get; set; }
    }
}
