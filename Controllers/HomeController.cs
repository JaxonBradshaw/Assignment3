﻿using Assignment3.Models;
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
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
            //getting for TempStorage
            return View(TempStorage.Movies);
        }
        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovies(MovieEntry movEntry)
            //posting to Tempstorage
        {
            TempStorage.AddMovie(movEntry);
            return View();
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
