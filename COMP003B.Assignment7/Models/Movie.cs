using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

        // Collection navigation property
        public virtual ICollection<MovieActor>? MovieActors { get; set; }

    }
}