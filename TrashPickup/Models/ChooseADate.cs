using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickup.Models
{
    public class ChooseADate
    {
        public ChooseADate()
        {

        }
        private List<DateTime> getWeekDays(DateTime dt)
        {
            List<DateTime> result = new List<DateTime>();
            int month = dt.Month;
            dt = dt.AddDays(-dt.Day + 1);
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                dt = dt.AddDays(2);
            }
            else if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                dt = dt.AddDays(1);
            }
            while (dt.Month == month)
            {
                result.Add(dt);
                dt = dt.AddDays(dt.DayOfWeek == DayOfWeek.Friday ? 3 : 1);
            }
            return result;
        }
    }
}