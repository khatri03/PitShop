﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Repositories.Model
{
    public class Aggregate
    {
        public string Id { get; set; }
        public int CurrentVersion { get; set; }
    }
}
