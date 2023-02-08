using System.ComponentModel.DataAnnotations;

namespace proiectDaw.Models.DTOs
{
    public class UserBookRelationRequestDTO
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid BookId { get; set; }
    }
}
