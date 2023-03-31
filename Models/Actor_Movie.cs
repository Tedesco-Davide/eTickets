using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        [ForeignKey("MovieId_ForeignKey")]
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        [ForeignKey("ActorId_ForeignKey")]
        public Actor Actor { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
