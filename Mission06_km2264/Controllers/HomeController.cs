using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_km2264.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_km2264.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext { get; set; }
        public HomeController(MovieContext movie)
        {
            _movieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovie(EnterMovieResponse response)
        {
            if (ModelState.IsValid) //checks if the model and its fields are valid when user enters in form
            {
                _movieContext.Add(response);
                _movieContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View(response);
            }
        }
        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult MovieList ()
        {
            var responses = _movieContext.Responses
                .Include(i => i.Category)
                .ToList();
            return View(responses);
        }
        [HttpGet]
        public IActionResult Edit (int responseid)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            var response = _movieContext.Responses.Single(x => x.Id == responseid);
            return View(response);
        }
        [HttpPost]
        public IActionResult Edit(EnterMovieResponse response)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Update(response); //updates record
                _movieContext.SaveChanges();
                return RedirectToAction("MovieList"); //redirects userback to "MovieList" action after updates were made
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View(response);
            }
        }
        [HttpGet]
        public IActionResult Delete (int responseid)
        {
            var response = _movieContext.Responses.Single(x => x.Id == responseid);
            return View(response);
        }
        [HttpPost]
        public IActionResult Delete (EnterMovieResponse response)
        {
            _movieContext.Responses.Remove(response); //removes record based on Id
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
