using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class Billing
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "User Id")]
        public int UserID { get; set; }
        [Display(Name = "Balance For Monthly Pick Up")]
        public double Balance { get; set; }
    }
}