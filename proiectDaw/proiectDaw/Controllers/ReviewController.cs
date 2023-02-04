using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiectDaw.Models;
using proiectDaw.Models.DTOs;
using proiectDaw.Services.ReviewService;

namespace proiectDaw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReviews()
        {
            var reviews = await _reviewService.GetAllReviews();
            return Ok(reviews);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReviewRequestDTO review)
        {
            var createReview = new Review
            {
                UserId = review.UserID,
                BookId = review.BookID,
                Message = review.Message,
                Rating = review.Rating,
            };
            await _reviewService.Create(createReview);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateReview(Guid id, ReviewRequestDTO review)
        {
            var updateReview = _reviewService.GetById(id);
            if (review == null)
            {
                return BadRequest("Not found");
            }

            updateReview.Message = review.Message;
            updateReview.Rating = review.Rating;

            _reviewService.Save();

            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteApartment(Guid id)
        {
            var deleteReview = _reviewService.GetById(id);
            if (deleteReview == null)
            {
                return BadRequest("Not found");
            }

            _reviewService.Delete(deleteReview);
            _reviewService.Save();
            return Ok();
        }

    }
}
