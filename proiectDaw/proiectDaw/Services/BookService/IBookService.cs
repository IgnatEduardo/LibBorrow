using proiectDaw.Models;

namespace proiectDaw.Services.BookService
{
    public interface IBookService
    {
        Book GetById(Guid id);
        Task<List<Book>> GetAllBooks();
        Task Create(Book newBook);
        Task Delete(Book deleteBook);
        Task Update(Book updateBook);
        bool Save();
    }
}
