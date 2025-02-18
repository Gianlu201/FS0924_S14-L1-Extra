using System.ComponentModel.DataAnnotations;

namespace FS0924_S14_L1_Extra.Models
{
    public class CreateBookModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "Poster is required")]
        public string? Poster { get; set; }
    }
}
