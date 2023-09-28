using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Web.BookStore.Models;

namespace Web.BookStore.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource().ToList();
        }

        public Book GetBookById(int id)
        {
            return DataSource().Where(item => item.Id == id).FirstOrDefault();
        }

        public Book SearchBook(string title,string author)
        {
            return DataSource().Where(item => item.Title.Contains(title) || item.Author.Contains(author)).FirstOrDefault();
        }

        public IEnumerable<Book> DataSource()
        {
            return new List<Book>
            {
                new Book { Id = 101, Title = "MVC", Author = "Sachin" },
                new Book { Id = 102, Title = "MVC", Author = "Kohli" },
                new Book { Id = 103, Title = "Dot Net Core", Author = "Rahul" },
                new Book { Id = 104, Title = "C#", Author = "Sehwag" },
                new Book { Id = 105, Title = "WPF", Author = "Dhoni" },
                new Book { Id = 106, Title = "VB", Author = "Gill" },
                new Book { Id = 107, Title = "F#", Author = "Shami" },
            };
        }
    }
}
