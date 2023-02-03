using proiectDaw.Models.Base;

namespace proiectDaw.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int NumOfBooks { get; set; }
        public DateTime DatePublished { get; set; }

        public Author Author { get; set; }
        public Guid AuthorId { get; set; }

        public ICollection<UserBookRelation> UserBookRelations { get; set; }
    }
}
