using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FishDemo.Models
{
    public class DriverModel
    {
        [Key]
        public int DriverId { get; set; }

  
        public virtual RideModel Ride { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int LicenseNumber { get; set; }
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        

    }
}