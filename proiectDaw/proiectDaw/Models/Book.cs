﻿using proiectDaw.Models.Base;

namespace proiectDaw.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public DateTime DatePublished { get; set; }

        public ICollection<Review>? Reviews { get; set; }

        public ICollection<UserBookRelation> UserBookRelations { get; set; }
    }
}
