using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class UpDateDays
    {
        [Display(Name = "Change Pick Up Day")]
        public string ChangeDay { get; set; }
        [Display(Name = "Hold/Start Service")]
        public string HoldStart { get; set; }
    }
}