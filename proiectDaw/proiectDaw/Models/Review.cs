using proiectDaw.Models.Base;

namespace proiectDaw.Models
{
    public class Review : BaseEntity
    {
        public string Message { get; set; }
        public int Rating { get; set; }

        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
    }
}
