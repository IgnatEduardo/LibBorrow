using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;

namespace proiectDaw.Repositories.SubscriptionRepository
{
    public interface ISubscriptionRepository : IGenericRepository<Subscription>
    {
        Subscription GetSubByEmail(string email);
    }
}
