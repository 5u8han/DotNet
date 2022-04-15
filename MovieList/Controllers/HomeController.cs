﻿using Microsoft.AspNetCore.Mvc;
using MovieList.Models;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }
        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var movies = context.Movies
            .Include(m => m.Genre)
            .OrderBy(m => m.Name)
            .ToList();
            return View(movies);
        }
    }
}
/* original for line 19
* var movies = context.Movies
* */



/*



namespace MovieList.Controllers
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
}*/