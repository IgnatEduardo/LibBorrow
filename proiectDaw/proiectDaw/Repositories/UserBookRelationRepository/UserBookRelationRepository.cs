using proiectDaw.Data;
using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;

namespace proiectDaw.Repositories.UserBookRelationRepository
{
    public class UserBookRelationRepository : GenericRepository<UserBookRelation>, IUserBookRelationRepository
    {
        public UserBookRelationRepository(Context context): base(context) { }
    }
}
