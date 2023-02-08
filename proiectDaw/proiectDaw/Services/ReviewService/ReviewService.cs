using proiectDaw.Data.UitOfWork;
using proiectDaw.Models;
using proiectDaw.Repositories.ReviewRepository;

namespace proiectDaw.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        public IReviewRepository _reviewRepository;
        public IUnitOfWork _unitOfWork;

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

        public async Task Update(Review updatedReview)
        {
            _reviewRepository.Update(updatedReview);
            await _unitOfWork.SaveAsync();
        }

        public async Task Delete(Review deleteReview)
        {
            _reviewRepository.Delete(deleteReview);
            await _unitOfWork.SaveAsync();
        }

        public bool Save()
        {
            return _reviewRepository.Save();
    }

        
    }
}
