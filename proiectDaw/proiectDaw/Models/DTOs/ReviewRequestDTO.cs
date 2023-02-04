using System.ComponentModel.DataAnnotations;

namespace proiectDaw.Models.DTOs
{
    public class ReviewRequestDTO
    {
        [Required]
        public Guid UserID { get; set; }

        [Required]
        public Guid BookID { get; set; }
        public string Message { get; set; }
        public string Rating { get; set; }

    }
}
