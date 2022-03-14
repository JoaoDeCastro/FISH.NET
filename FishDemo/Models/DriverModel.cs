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

        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Driver's License Number")]
        public string LicenseNumber { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string Phone { get; set; }


       
        [StringLength(255)]
        [Display(Name = "Dates Available")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public string DateAvailable { get; set; }

    }
}