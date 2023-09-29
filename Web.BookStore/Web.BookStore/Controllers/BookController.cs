using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Web.BookStore.Models;
using Web.BookStore.Repository;

namespace Web.BookStore.Controllers
{
    public class BookController : Controller
    {
        readonly BookRepository bookRepository = null;

        [ViewData]
        public string ctl2 { get; set; }

        public BookController()
        {

            bookRepository = new BookRepository();
        }

        public IActionResult GetAllBooks()
        {
            ViewBag.ctl = "from controller";
            ctl2 = "from controller 2";
            return View(bookRepository.GetAllBooks().ToList());
        }

        public IActionResult GetBook(int id)
        {
            Book book = bookRepository.GetBookById(id);
            ViewData["Books"] = bookRepository.GetAllBooks().ToList()
                .Where(item => !String.IsNullOrEmpty(item.Tags) && item.Tags == book.Tags).ToList();
            return View(book);
        }

        public Book SearchBook(string title, string author)
        {
            return bookRepository.SearchBook(title, author);
        }

        public IActionResult AddNewBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewBook(Book book)
        {
            bookRepository.AddBook(book);
            return RedirectToAction("GetAllBooks");
        }
    }
}
