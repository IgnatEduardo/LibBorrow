using proiectDaw.Data;
using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;
using System.Linq;

namespace proiectDaw.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }

        public ICollection<User> FindAll()
        {
            return (ICollection<User>)_table.Join(_context.Subscriptions, u => u.Id, s => s.UserId, (u, s) => new { u, s }).Select(r => r.u);
        }

        public User FindByEmail(string email)
        {
            return _table.FirstOrDefault(x => x.Email == email);
        }
    }
}
