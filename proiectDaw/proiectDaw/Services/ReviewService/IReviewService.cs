using proiectDaw.Models;

namespace proiectDaw.Services.ReviewService
{
    public interface IReviewService
    {
        Review GetById(Guid id);

        Task Create(Review newReview);
        void Update(Review updateReview);
        void Delete(Review deleteReview);
        Task<List<Review>> GetAllReviews();
        bool Save();
    }
}
