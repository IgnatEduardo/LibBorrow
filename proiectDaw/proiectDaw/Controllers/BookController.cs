using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiectDaw.Models.DTOs;
using proiectDaw.Models;
using proiectDaw.Services.BookService;

namespace proiectDaw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookRequestDTO book)
        {
            var createBook = new Book
            {
                Title = book.Title,
                Author = book.Author,
                Language = book.Language,
                DatePublished = book.DatePublished,
            };
            await _bookService.Create(createBook);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateBook(Guid id, BookRequestDTO book)
        {
            var updateBook = _bookService.GetById(id);
            if (book == null)
            {
                return BadRequest("Not found");
            }

            updateBook.Title = book.Title;
            updateBook.Author = book.Author;
            updateBook.Language = book.Language;
            updateBook.DatePublished = book.DatePublished;

            _bookService.Save();

            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            var deleteBook = _bookService.GetById(id);
            if (deleteBook == null)
            {
                return BadRequest("Not found");
            }

            _bookService.Delete(deleteBook);
            _bookService.Save();
            return Ok();
        }
    }
}
