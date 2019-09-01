using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var allBooks = db.Books.ToList();
                return this.View(allBooks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string title, string author, double price)
        {
            if (string.IsNullOrEmpty(title))
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibraryDbContext())
            {
                Book books = new Book
                {
                    Title = title,
                    Author = author,
                    Price = price,
                };
                db.Books.Add(books);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(x => x.Id == id);

                if (bookToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return this.View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book books)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(x => x.Id == books.Id);
                bookToEdit.Title = books.Title;
                bookToEdit.Author = books.Author;
                bookToEdit.Price = books.Price;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToDelete = db.Books.FirstOrDefault(x => x.Id == id);
                if (bookToDelete == null)
                {
                    RedirectToAction("Index");
                }
                return this.View(bookToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book books)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Remove(books);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}