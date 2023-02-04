using proiectDaw.Models;
using proiectDaw.Repositories.ReviewRepository;

namespace proiectDaw.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        public IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<List<Review>> GetAllReviews()
        {
            return await _reviewRepository.GetAllAsync();
        }
        public Review GetById(Guid id)
        {
            return _reviewRepository.FindById(id);
        }

        public async Task Create(Review newReview)
        {
            await _reviewRepository.CreateAsync(newReview);
            await _reviewRepository.SaveAsync();
        }

        public void Update(Review updatedReview)
        {
            _reviewRepository.Update(updatedReview);
        }

        public void Delete(Review deleteReview)
        {
            _reviewRepository.Delete(deleteReview);
        }

        

        public bool Save()
        {
            return _reviewRepository.Save();
        }

        
    }
}
