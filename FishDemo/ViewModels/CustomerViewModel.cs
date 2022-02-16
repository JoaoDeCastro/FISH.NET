using FishDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishDemo.ViewModels
{
    public class CustomerViewModel
    {
        public RideModel Ride { get; set; }
        public CustomerModel Customer { get; set; }
    }
}