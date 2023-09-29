using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Web.BookStore.Models;

namespace Web.BookStore.Repository
{
    public class BookRepository
    {
        private static List<Book> lstBooks {  get; set; }

        static BookRepository()
        {
            loadData();
        }
        public List<Book> GetAllBooks()
        {
            return lstBooks.ToList();
        }

        public Book GetBookById(int id)
        {
            return lstBooks.Where(item => item.Id == id).FirstOrDefault();
        }

        public Book SearchBook(string title,string author)
        {
            return lstBooks.Where(item => item.Title.Contains(title) || item.Author.Contains(author)).FirstOrDefault();
        }

        public void AddBook(Book book)
        {
            lstBooks.Add(book);
        }

        private static IEnumerable<Book> loadData()
        {
            lstBooks = new List<Book>
            {
                new Book { Id = 101, Title = "MVC", Author = "Sachin", Description="Book description", Tags="MVC" },
                new Book { Id = 102, Title = "MVC", Author = "Kohli", Description="Book description", Tags="MVC" },
                new Book { Id = 103, Title = "Dot Net Core", Author = "Rahul", Description="Book description", Tags="MVC" },
                new Book { Id = 104, Title = "C#", Author = "Sehwag", Tags="C#" },
                new Book { Id = 105, Title = "WPF", Author = "Dhoni", Description="Book description", Tags="C#" },
                new Book { Id = 106, Title = "VB", Author = "Gill", Description="Book description" },
                new Book { Id = 107, Title = "F#", Author = "Shami", Description="Book description" },
            };
            return lstBooks;
        }
    }
}
