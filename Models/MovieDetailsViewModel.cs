using MvcMovie.Dtos;

namespace MvcMovie.Models
{
    public class MovieDetailsViewModel
    {
        public required Movie Movie { get; set; }
        public required ReviewDto Review { get; set; }
    }
}
