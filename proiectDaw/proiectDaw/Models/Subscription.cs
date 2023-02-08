using proiectDaw.Models.Base;

namespace proiectDaw.Models
{
    public class Subscription : BaseEntity
    {
        public string TypePlan { get; set; }
        public int Payment { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
