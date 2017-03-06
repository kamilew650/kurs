using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate( int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name="Shrek", Id=1 },
                new Movie {Name="Piraci z Karajibuf", Id=2 }
            };

            var m = new IndexMovieViewModel
            {
                Ile = movies.Count(),
                Movies = movies
            };

            return View(m);
        }

        public ActionResult Details(int Id)
        {

            return Content(Convert.ToString(Id));
        }
    }
}