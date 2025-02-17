namespace FS0924_S14_L1_Extra.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int? Year { get; set; }
        public string? Genre { get; set; }
        public string? Poster { get; set; }
    }
}
