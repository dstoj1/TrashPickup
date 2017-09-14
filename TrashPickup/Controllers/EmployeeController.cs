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
            return RedirectToAction("Index", "Home");
        }
        public ActionResult ShowAddress()
        {
            string UserName = User.Identity.GetUserName();
            var user = from x in Data.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            List<Address> Addresses = (from x in Data.Address where x.Zip == CurrentUser.ZipCode && x.Day.ToLower() == DateTime.Now.DayOfWeek.ToString().ToLower()  select x).ToList();
            return View(Addresses);
        }            
        public ActionResult AddCharge(int id)

       {
            Billing account;
            var address = (from x in Data.Address.Include("User") where x.ID == id select x).First();
            try { account = (from x in Data.Billing where x.User.Id == address.User.Id select x).First(); }
            catch
            {
                var user = (from x in Data.Users where x.Id == address.User.Id select x).First();
                Billing Account = new Billing();
                Account.User = user;
                Data.Billing.Add(Account);
                Data.SaveChanges();
                account = (from x in Data.Billing where x.User.Id == address.User.Id select x).First();
            }
            account.Balance += 35.00;
            Data.SaveChanges();
            return RedirectToAction("ShowAddress", "Employee");
        }
    }
}