using FilmeLivroEntityFramework.Dal;
using FilmeLivroEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmeLivroEntityFramework.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext _ctxMovie = new MovieContext();

        // GET: Movie
        public ActionResult Index()
        {
            return View(_ctxMovie.Movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                _ctxMovie.Movies.Add(m);
                _ctxMovie.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m);
        }

        public ActionResult Edit(int id)
        {
            return View(_ctxMovie.Movies.First(m => m.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                Movie movieUpdate = _ctxMovie.Movies.First(m => m.Id == movie.Id);
                movieUpdate.Note = movie.Note;
                movieUpdate.Title = movie.Title;
                movieUpdate.Director = movie.Director;
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Details(int id)
        {
            return View(_ctxMovie.Movies.First(m => m.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(_ctxMovie.Movies.First(m => m.Id == id));
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var movie = _ctxMovie.Movies.First(m => m.Id == id);
            _ctxMovie.Movies.Remove(movie);
            _ctxMovie.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}