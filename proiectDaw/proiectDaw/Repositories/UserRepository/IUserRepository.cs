using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;

namespace proiectDaw.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        ICollection<User> FindAll();
        User FindByEmail(string email);
    }
}
