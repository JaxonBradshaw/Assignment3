using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {

        private MovieDbContext context { get; set; }
        public HomeController(MovieDbContext con)
        {
            context = con;
        }

        //private readonly ILogger<HomeController> _logger;

        //private IMovieRepository _repository;

        //passing in Movie repository when controller is created
        //public HomeController(ILogger<HomeController> logger, IMovieRepository repository)
        //{
        //    _logger = logger;
        //    _repository = repository;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MyPodcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieList()
        {
            //passing data to view
            return View(context.Movies);
        }
        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult AddMovies(Movie movEntry)
        //    //posting to Tempstorage
        //{
        //   // TempStorage.AddMovie(movEntry);
        //    return View();
        //}

        [HttpPost]
        public IActionResult AddMovies(Movie m)
        {
            if (ModelState.IsValid)
            {
                //adding entry into database
                context.Movies.Add(m);
                context.SaveChanges();
            }

            return View();
        }

        //setting up edit view
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = context.Movies.Where(s => s.MovieId == id).FirstOrDefault();

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            
            var mov = context.Movies.Where(s => s.MovieId == movie.MovieId).FirstOrDefault();
            context.Movies.Remove(mov);
            context.Movies.Add(movie);
            context.SaveChanges();

            return RedirectToAction("MovieList", context.Movies);
        }

        public IActionResult Delete(int id)
        {
            var movie = context.Movies.Where(s => s.MovieId == id).FirstOrDefault();

            context.Movies.Remove(movie);
            context.SaveChanges();

            return RedirectToAction("MovieList");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
