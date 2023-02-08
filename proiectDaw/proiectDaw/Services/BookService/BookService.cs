using proiectDaw.Data.UitOfWork;
using proiectDaw.Models;
using proiectDaw.Repositories.BookRepository;

namespace proiectDaw.Services.BookService
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;

        public IUnitOfWork _unitOfWork;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Create(Book newBook)
        {
            await _bookRepository.CreateAsync(newBook);
            await _bookRepository.SaveAsync();
        }

        public async Task Delete(Book deleteBook)
        {
            _bookRepository.Delete(deleteBook);
            await _unitOfWork.SaveAsync();
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

        public async Task Update(Book updateBook)
        {
            _bookRepository.Update(updateBook);
            await _unitOfWork.SaveAsync();
        }
    }
}
