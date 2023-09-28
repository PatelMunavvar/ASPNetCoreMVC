using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            return View(bookRepository.GetBookById(id));
        }

        public Book SearchBook(string title, string author)
        {
            return bookRepository.SearchBook(title, author);
        }


    }
}
