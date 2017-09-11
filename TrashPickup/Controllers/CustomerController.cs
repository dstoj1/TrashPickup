using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class CustomerController : Controller
    {
        ApplicationDbContext Data;
        public CustomerController()
        {
            Data = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PickUp()
        {
            string UserName = User.Identity.GetUserName();
            var user = from x in Data.Users where x.UserName == UserName select x;
            var CurrentUser = user.First();
            var addresses = from x in Data.Address where x.User.Id == CurrentUser.Id select x;
            List<Address> model = addresses.ToList();

            return View(model);
        }
        [HttpGet]
        public ActionResult AddAddress(int AddressId)
        {
            Address Model = new Address();
            return View(Model);
        }
    }
}