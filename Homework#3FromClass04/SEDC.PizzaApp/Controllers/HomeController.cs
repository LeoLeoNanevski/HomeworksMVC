﻿using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using System.Diagnostics;

namespace SEDC.PizzaApp.Controllers
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

        //http://localhost:[port]/AboutUs
        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SeeUsers()
        {
            List<User> users = StaticDb.Users;
            List<string> fullNames = users.Select(fn => $"{fn.FirstName} {fn.LastName}").ToList();
            return View(fullNames);
        }
    }
}