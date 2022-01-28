using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppContext = DateMe.Models.AppContext;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private AppContext daContext { get; set; }

        public HomeController(AppContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Application()
        {
            ViewBag.Directors = daContext.Directors.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Application(ApplicationResponse ar)
        {
            daContext.Add(ar);
            daContext.SaveChanges();

            return View("Confirm", ar);
        }

        public IActionResult WaitList()
        {
            var movie_list = daContext.responses
                .Where(x => x.Rating == "PG-13")
                .OrderBy(x => x.Title)
                .ToList();

            return View(movie_list);
        }
    }
}