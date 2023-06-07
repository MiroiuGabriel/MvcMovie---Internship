using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Dtos
{
    public class ReviewDto
    {
        [Required]
        public int MovieId { get; set; }
        [MinLength(4), MaxLength(20), Required]
        public string Username { get; set; } = string.Empty;

        [MinLength(4), MaxLength(200), Required, DisplayName("Review")]
        public string Content { get; set; } = string.Empty;
    }
}
