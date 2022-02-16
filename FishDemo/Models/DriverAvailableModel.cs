using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FishDemo.Models
{
    public class DriverAvailableModel
    {
        [ForeignKey("DriverId")]
        public int DriverId { get; set; }
        public DriverModel Driver { get; set; }
        public List <DateTime> DatesAvailable { get; set; }

    }
}