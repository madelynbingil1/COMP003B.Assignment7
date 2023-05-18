using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Actor 
    {
        public int ActorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Collection navigation property
        public virtual ICollection<MovieActor>? MovieActors { get; set; }

    }
}