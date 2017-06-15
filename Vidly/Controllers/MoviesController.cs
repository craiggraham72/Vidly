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
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //Both of these options require casting
            //It is easier to pass the  object to the view.
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;



            return View(viewModel);
        }

        public ActionResult Edit (int id)
        {
            return Content("ID=" + id);
        }

        //Movies
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }


        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Star Trek" },
                new Movie { Id = 3, Name = "Matrix" }
            };
        }
    }
}