using PitShop.Web.Models;
using System.Collections.Generic;

namespace PitShop.Web.ViewModels
{
    public class VehicleManagementViewModel
    {
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
