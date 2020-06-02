using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidMVC.Models;
using VidMVC.ViewModel;

namespace VidMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Collection()
        {
            var customer = new List<Customer> {
                new Customer{Name ="Jack Ma "},
                new Customer{Name ="Elon Musk "}
            };

            var CustomList = new CustomerCollectionViewModel
            {
                Customers = customer

            };
            return View(CustomList);
        }
        [Route("Customer/Collection/{Id}")]
        public ActionResult ByCustomerId(int Id)
        {
            return Content("Customer Id =" + Id);
        }
    }
}