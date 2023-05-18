using System.ComponentModel.DataAnnotations;


namespace COMP003B.Assignment7.Models
{
    public class MovieActor
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        // Nullable navigation properties
        public virtual Movie? Movie { get; set; }
        public virtual Actor? Actor { get; set; }
    }
}