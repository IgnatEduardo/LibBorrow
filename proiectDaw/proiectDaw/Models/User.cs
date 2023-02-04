using proiectDaw.Models.Base;

namespace proiectDaw.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }

        public Subscription Subscription { get; set; }

        public ICollection<UserBookRelation> UserBookRelations { get; set; }

    }
}
