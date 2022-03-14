using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FishDemo.Models
{

    public enum Gender
    {
        Male,
        Female
    }
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }

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
        [Display(Name = "Phone Number")]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Emergency Phone Contact")]
        [Phone]
        public string EmergencyContact { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }
       
        public Gender Gender { get; set; }

        
        [Display(Name = "Street")]
        [StringLength(255)]
        public string PickUpStreet { get; set; }

        
        [Display(Name = "City")]
        [StringLength(255)]
        public string PickUpCity { get; set; }

        
        [Display(Name = "State")]
        [StringLength(20)]
        public string PickUpState { get; set; }

       
        [StringLength(255)]
        [Display(Name = "Zip code")]
        public string PickUpZip { get; set; }

       
        public virtual RideModel ride { get; set; }
        //needs to be a list of rides
    }

}

    