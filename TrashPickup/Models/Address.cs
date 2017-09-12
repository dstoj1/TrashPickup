using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Address
    {
        [Display (Name = "ID")]
        public int ID { get; set;}
        [Display(Name = "Address")]
        public string AddressLine { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip")]
        public int Zip { get; set;}
        [Display(Name = "Choose A Pick Up Day")]
        public string Day { get; set; }
        public ApplicationUser User { get; set;}
    }
}