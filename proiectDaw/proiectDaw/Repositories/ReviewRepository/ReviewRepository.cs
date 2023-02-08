using proiectDaw.Data;
using proiectDaw.Models;
using proiectDaw.Repositories.GenericRepository;

namespace proiectDaw.Repositories.ReviewRepository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(Context context) : base(context)
        {
        }
    }
}
