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
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Movies()
        {
            var movi = _context.Movies.Include(g => g.Genres).ToList();

            var viewModel = new RandomMoviesViewModel
            {
                Movies = movi
            };

            return View(viewModel);
        }

        public ActionResult MovieById(int? id)
        {
            if (!id.HasValue)
            {
                return Content("No movie found!");
            }            
            else
            {
                var moviebyId = _context.Movies.Include(g => g.Genres).SingleOrDefault(m => m.Id == id);
                return View(moviebyId);
            }
        }
    }
}