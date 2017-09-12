using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Address
    {
        public int ID { get; set;}
        [Display (Name = "ID")]
        public string AddressLine { get; set; }
        [Display(Name = "Address")]
        public string City { get; set; }
        [Display(Name = "City")]
        public string State { get; set; }
        [Display(Name = "State")]
        public int Zip { get; set;}
        [Display(Name = "Zip")]
        public string Day { get; set; }
        [Display(Name = "Day")]
        public ApplicationUser User { get; set;}
    }
}