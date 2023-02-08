using System.ComponentModel.DataAnnotations;

namespace proiectDaw.Models.DTOs
{
    public class SubscriptionRequestDTO
    {
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string TypePlan { get; set; }
        public int Payment { get; set; }
    }
}
