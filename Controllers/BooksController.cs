using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // url - /api/books/all
        [Route("all")]
        public IEnumerable<Book> GetAllBooks()
        {
            //returning random 10 books
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(index => new Book
            {
                Id = index,
                Title = "Book" + index,
                AuthorName = "Author" + index,
                ISBN = "ABC" + rng.Next(100000, 999999),
                Subject = "Life",
                Language = (Language)rng.Next(9),
                Price = rng.Next(100, 2000),
                PublisherName = "Publisher" + index,
                PublicationDate = new DateTime(2020, 03, 25),
                DateOfPurchase = new DateTime(2020, 04, 01),
                NoOfPages = rng.Next(100,500),
            })
            .ToArray();
        }

        // url - /api/books/details/4
        [Route("detail/{id}")]
        public Book GetBookById(int id)
        {
            //returning random book
            var rng = new Random();
            return new Book()
            {
                Id = id,
                Title = "Book" + id,
                AuthorName = "Author" + id,
                ISBN = "ABC" + rng.Next(100000, 999999),
                Subject = "Life",
                Language = (Language)rng.Next(9),
                Price = rng.Next(100, 2000),
                PublisherName = "Publisher" + id,
                PublicationDate = new DateTime(2020, 03, 25),
                DateOfPurchase = new DateTime(2020, 04, 01),
                NoOfPages = rng.Next(100, 500),
            };
        }

        // url - /api/books/add
        [Route("add")]
        public int PostNewBook([FromBody] Book book)
        {
            //service call for adding new book
            var rng = new Random();
            return rng.Next(1000);
        }

        // url - /api/books/update/4
        [Route("update/{id}")]
        public bool PutBookDetails(int id, [FromBody] Book updatedBook)
        {
            //service call for updating a book
            return true;
        }

        // url - /api/books/delete/4
        [Route("delete/{id}")]
        public bool DeleteBook(int id)
        {
            //service  call for deleting a book
            return true;
        }

        // url - /api/books/available
        [Route("available")]
        public IEnumerable<Book> GetAvailableBooks()
        {
            // return lists of books which are not issued.
            return new List<Book>();
        }
    }
}
