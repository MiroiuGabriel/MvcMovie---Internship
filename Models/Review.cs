using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayName("Completion Date")]
        public DateTime CompletionDate { get; set; } = DateTime.Now;

        [DisplayName("Review")]
        public string Content { get; set; } = string.Empty;

        public int MovieId { get; set; }
        public Movie Movie { get; set; } = default!;
    }
}
