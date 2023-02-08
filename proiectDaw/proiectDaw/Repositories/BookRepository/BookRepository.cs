using Microsoft.EntityFrameworkCore;
using proiectDaw.Data;
using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;

namespace proiectDaw.Repositories.BookRepository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(Context context) : base(context) 
        {
        
        }

        public Book FindByTitle(string title)
        {
            return _table.FirstOrDefault(x => x.Title == title);
        }

        public ICollection<Book> GetAll()
        {
            return (ICollection<Book>)_table.Include(b => b.UserBookRelations);
        }
    }
}
