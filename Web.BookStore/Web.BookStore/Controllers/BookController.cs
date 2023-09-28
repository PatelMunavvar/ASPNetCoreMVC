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

        public BookController()
        {
            bookRepository = new BookRepository();
        }

        public IEnumerable<Book> GetBooks()
        {
            return bookRepository.GetAllBooks().ToList();
        }

        public Book GetBook(int id)
        {
            return bookRepository.GetBookById(id);
        }

        public Book SearchBook(string title, string author)
        {
            return bookRepository.SearchBook(title, author);
        }


    }
}
