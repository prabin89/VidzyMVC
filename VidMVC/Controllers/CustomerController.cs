using System;
using System.Collections;
using System.Data.Entity;
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
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ViewResult Collection()
        {
            var customer = _context.Customers.ToList();

            return View(customer);
        }
        [Route("Customer/Collection/{Id}")]
        public ActionResult Details(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

           return Content(customer.Name);
        }
    }
}