﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class Address
    {
        public int AddressID { get; set; }
        public string? Detail { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? BusinessHoursMidWeek { get; set; }
        public string? BusinessHoursMidWeekand { get; set; }
    }
}
