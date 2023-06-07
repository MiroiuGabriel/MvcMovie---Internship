namespace MvcMovie.Models
{
    public class VideoGame
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string Publisher { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }

        // Additional properties and methods can be added based on your requirements
    }
}
