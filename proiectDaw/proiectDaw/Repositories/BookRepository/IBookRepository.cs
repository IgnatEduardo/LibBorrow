using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;

namespace proiectDaw.Repositories.BookRepository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        ICollection<Book> GetAll();
        Book FindByTitle(string title);
    }
}
