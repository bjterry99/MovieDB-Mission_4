using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Application(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();

                return View("Confirm", ar);
            }
            else
            {
                ViewBag.Directors = daContext.Directors.ToList();
                ViewBag.Categories = daContext.Categories.ToList();
                return View(ar);
            }
        }

        [HttpGet]
        public IActionResult WaitList()
        {
            var movie_list = daContext.responses
                .Include(x => x.Director)
                .Include(x => x.Category)
                //.Where(x => x.Rating == "PG-13")
                .OrderBy(x => x.Title)
                .ToList();

            return View(movie_list);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Directors = daContext.Directors.ToList();
            ViewBag.Categories = daContext.Categories.ToList();

            var movie = daContext.responses.Single(x => x.MovieId == movieid);

            return View("Application", movie);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse moviestuff)
        {
            daContext.Update(moviestuff);
            daContext.SaveChanges();

            return RedirectToAction("WaitList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = daContext.responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.responses.Remove(ar);
            daContext.SaveChanges();

            return RedirectToAction("WaitList");
        }
    }
}