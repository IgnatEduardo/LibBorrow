using proiectDaw.Models.Base;

namespace proiectDaw.Models
{
    public class UserBookRelation : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}
