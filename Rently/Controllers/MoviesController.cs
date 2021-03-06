﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rently.Models;
using Rently.ViewModel;

namespace Rently.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}