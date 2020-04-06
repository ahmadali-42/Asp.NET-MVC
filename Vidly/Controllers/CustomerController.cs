using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
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

        // GET: Movie
        public ActionResult Customers()
        {
            var cust = _context.Customers.Include(c => c.MembershipType).ToList();

            var viewModel = new RandomCustomersViewModel
            {
                Customers = cust as List<Customer>
            };

            return View(viewModel);

        }

        public ActionResult CustomerById(int? id)
        {
            if (!id.HasValue)
            {
                return Content("No customer found!");
            }

            else
            {
                var customer = _context.Customers.Include(m => m.MembershipType).SingleOrDefault(c => c.Id == id);

                return View(customer);
            }
        }

    }
}