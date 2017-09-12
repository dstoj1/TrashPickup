using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class ChooseADate
    {
        [Display(Name = "Choose Another Day for Pick Up")]
        public int AnotherDayForPickUp { get; set; }
        [Display(Name = "Please Put Pick Up On Hold")]
        public string PickUpOnHold { get; set; }
        public ApplicationUser User { get; set; }
    }
}

        //private List<DateTime> getWeekDays(DateTime WeekDays)
        //{
        //    List<DateTime> result = new List<DateTime>();
        //    int month = WeekDays.Month;
        //    WeekDays = WeekDays.AddDays(-WeekDays.Day + 1);
        //    if (WeekDays.DayOfWeek == DayOfWeek.Saturday)
        //    {
        //        WeekDays = WeekDays.AddDays(2);
        //    }
        //    else if (WeekDays.DayOfWeek == DayOfWeek.Sunday)
        //    {
        //        WeekDays = WeekDays.AddDays(1);
        //    }
        //    while (WeekDays.Month == month)
        //    {
        //        result.Add(WeekDays);
        //        WeekDays = WeekDays.AddDays(WeekDays.DayOfWeek == DayOfWeek.Friday ? 3 : 1);
        //    }
        //    return result;
        //}
    //     <div class="form-group">
    //    @Html.Label("user Role", new { @class = "col-md-2 control-label" })
    //    <div class="col-md-10">
    //        @* @Html.DropDownList("Name")*@
    //        @Html.DropDownList("UserRoles", (SelectList)ViewBag.Name, " ")
    //    </div>
    //</div>

        
        //    <asp:DropDownList ID = "ddlDay" runat="server">

//</asp:DropDownList>