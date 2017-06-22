using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new Models.ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            //Creat ViewModels to pass data to view
            var ViewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", ViewModel);
        }

        public ActionResult NewUpdate(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }


            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            try
            {
                _context.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Movies");
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Movie>
            {
                new Movie {Name = "Customer 1" },
                new Movie {Name = "Customer 2" }
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

        //public ActionResult Edit (int id)
        //{
        //    var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

        //    if (movie == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    var viewModel = new MovieFormViewModel
        //    {
        //        Movie = movie,
        //        Genres = _context.Genres.ToList()
        //    };
        //    return View("MovieForm", viewModel);
        //}

        //Movies

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();

            return View(movies);
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);

        }

    }
}