using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }


        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate( int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            var Movies = _context.Movies.Include(c => c.Genre).ToList();

            return View(Movies);
        }

        public ActionResult Details(int Id)
        {
            var Movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == Id);
            return View(Movie);
        }
    }
}