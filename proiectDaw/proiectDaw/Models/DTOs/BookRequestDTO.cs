using System.ComponentModel.DataAnnotations;

namespace proiectDaw.Models.DTOs
{
    public class BookRequestDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Language { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
