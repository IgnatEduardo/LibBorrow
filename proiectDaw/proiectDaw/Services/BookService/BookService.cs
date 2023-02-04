using proiectDaw.Models;
using proiectDaw.Repositories.BookRepository;

namespace proiectDaw.Services.BookService
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Create(Book newBook)
        {
            await _bookRepository.CreateAsync(newBook);
            await _bookRepository.SaveAsync();
        }

        public void Delete(Book deleteBook)
        {
            _bookRepository.Delete(deleteBook);
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAllAsync();
        }

        public Book GetById(Guid id)
        {
            return _bookRepository.FindById(id);
        }

        public bool Save()
        {
            return _bookRepository.Save();
        }

        public void Update(Book updateBook)
        {
            _bookRepository.Update(updateBook);
        }
    }
}
