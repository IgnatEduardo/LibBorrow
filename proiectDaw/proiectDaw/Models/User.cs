using proiectDaw.Helper;
using proiectDaw.Models.Base;
using System.Data;
using System.Text.Json.Serialization;

namespace proiectDaw.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
        public Subscription Subscription { get; set; }

        public ICollection<UserBookRelation> UserBookRelations { get; set; }

        public Roles Role { get; set; }
    }
}
