using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AspNetStudy.Models
{
    [Table("film_actor")]
    public class FilmActorDto
    {
        [Key]
        public int film_id { get; set; }
        [Key]
        public int actor_id { get; set; }

  
        public ActorDto actor { get; set; }
        public FilmDto film { get; set; }
    }
}
