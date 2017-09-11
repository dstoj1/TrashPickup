using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Address
    {
        public int ID { get; set;}
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set;}
        public string Day { get; set; }
        public ApplicationUser User { get; set;}
    }
}