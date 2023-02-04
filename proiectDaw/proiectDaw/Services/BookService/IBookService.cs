using proiectDaw.Models;

namespace proiectDaw.Services.BookService
{
    public interface IBookService
    {
        Book GetById(Guid id);
        Task<List<Book>> GetAllBooks();
        Task Create(Book newBook);
        void Delete(Book deleteBook);
        void Update(Book updateBook);
        bool Save();
    }
}
