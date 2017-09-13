using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        ApplicationDbContext Data;
        public EmployeeController()
        {
            Data = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ChangeZip()
        {
            string UserName = User.Identity.GetUserName();
            var user = from x in Data.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            return View(CurrentUser);
        }
        [HttpPost]
        public ActionResult ChangeZip(ApplicationUser Employee)
        {
            string UserName = User.Identity.GetUserName();
            var user = from x in Data.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            CurrentUser.ZipCode = Employee.ZipCode;
            Data.SaveChanges();
            return RedirectToAction("Home", "Index");
        }
             
        public ActionResult AddCharge()
        {
            return View();
        }
        //[HttpPost]
        ////public ActionResult AddCharge(string UserID)
        ////{
        ////    var account = (from x in Data.Billing where x.User.Id == UserID select x).First();
        ////    account.Balance += 35.00;
        ////    Data.SaveChanges();
        ////    //return RedirectToAction("Billing", "Customer");
        ////}
        ////public ActionResult PickTrash()
        ////{
        ////    var
        //}
    }
}