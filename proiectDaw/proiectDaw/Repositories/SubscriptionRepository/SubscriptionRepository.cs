using proiectDaw.Data;
using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;

namespace proiectDaw.Repositories.SubscriptionRepository
{
    public class SubscriptionRepository : GenericRepository<Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(Context context) : base(context) { }

        public Subscription GetSubByEmail(string email)
        {
            return _table.FirstOrDefault(s => s.User.Email == email);
        }
    }
}
