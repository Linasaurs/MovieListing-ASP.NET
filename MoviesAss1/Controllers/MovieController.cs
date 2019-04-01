using MoviesAss1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesAss1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View(Movie.MovieList);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(Movie newMovie)
        {
            try
            {
                Movie.AddMovie(newMovie);
                Index();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int Id)
        {
            var mov = Movie.MovieList.Where(s => s.id == Id).FirstOrDefault();
            return View(mov);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, Movie editMovie)
        {
            try
            {
                var mov = Movie.MovieList.Where(s => s.id == Id).FirstOrDefault();
                mov.name = editMovie.name;
                mov.mainActor = editMovie.mainActor;
                mov.releaseDate = editMovie.releaseDate;
                mov.website = editMovie.website;
                mov.countryId = editMovie.countryId;
                Index();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int Id)
        {
            var mov = Movie.MovieList.Where(s => s.id == Id).FirstOrDefault();
            return View(mov);
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, Movie delMovie)
        {
            try
            {
                var mov = Movie.MovieList.Where(s => s.id == Id).FirstOrDefault();
                Movie.MovieList.Remove(mov);
                mov = null;
                Index();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
