using proiectDaw.Models;

namespace proiectDaw.Services.ReviewService
{
    public interface IReviewService
    {
        Review GetById(Guid id);
        Task<List<Review>> GetAllReviews();
        Task Create(Review newReview);
        Task Update(Review updateReview);
        Task Delete(Review deleteReview);
        bool Save();
    }
}
