using FilmeLivroEntityFramework.Dal;
using FilmeLivroEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmeLivroEntityFramework.Controllers
{
    public class BookController : Controller
    {
        private BookContext _ctxBook = new BookContext();

        // GET: Book
        public ActionResult Index()
        {
            return View(_ctxBook.Books.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book b)
        {
            if (ModelState.IsValid)
            {
                _ctxBook.Books.Add(b);
                _ctxBook.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(b);
        }

        public ActionResult Edit(int id)
        {
            return View(_ctxBook.Books.First(b => b.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                Book bookUpdate = _ctxBook.Books.First(b=> b.Id == book.Id);
                bookUpdate.Note = book.Note;
                bookUpdate.Title = book.Title;
                bookUpdate.Autor = book.Autor;
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public ActionResult Details(int id)
        {
            return View(_ctxBook.Books.First(b => b.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(_ctxBook.Books.First(b => b.Id == id));
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var book = _ctxBook.Books.First(b => b.Id == id);
            _ctxBook.Books.Remove(book);
            _ctxBook.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}