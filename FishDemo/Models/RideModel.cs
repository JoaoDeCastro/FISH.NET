using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FishDemo.Models
{
    public enum RideStatus
    {
        Pending = 1,
        InProgress = 2,
        Commited = 3,
        Done
    }

    public class RideModel
    {
       

        [Key]
        public int RideId { get; set; }

        [Required]
        [Display(Name = "Date of pick up")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyy}", ApplyFormatInEditMode = true)]
        public DateTime pickUpDate { get; set; }

        public RideStatus Status { get; set; }

        [Required]
        [Display(Name = "Time for pick up")]
        [DataType(DataType.Time)]
        
        public string Time { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Where to")]
        public string DestinationStreet { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "City")]
        public string DestinationCity { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "State")]
        public string DestinationState { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Zip Code")]
        public string DestinationZip { get; set; }

        [StringLength(500)]
        [Display(Name = "Any special need?")]
        public string SpecialNeed { get; set; }

        [StringLength(255)]
        [Display(Name = "Lenght Of Appointment")]
        public string LenghtOfAppointment { get; set; }

       
        // need to have one to one relationship
        // a ride has a customer

    }
}