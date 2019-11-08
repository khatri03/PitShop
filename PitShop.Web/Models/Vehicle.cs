using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.Web.Models
{
    public class Vehicle
    {
        [Required]
        [Display(Name = "License number")]
        public string LicenseNumber { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Owner")]
        public string OwnerId { get; set; }
    }
}
