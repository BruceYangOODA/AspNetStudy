using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetStudy.Models
{
    [Table("actor")]
    public class ActorDto
    {
        [Key]
        public int actor_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string last_update { get; set; }

        public List<FilmActorDto>? filmActors { get; set; }

    }
}
