using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AspNetStudy.Models
{
    [Table("film")]
    public class FilmDto
    {
        [Key]
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int release_year { get; set; }
        public int language_id { get; set; }
        public int rental_duration { get; set; }
        public float rental_rate { get; set; }
        public int length { get; set; }
        public float replacement_cost { get; set; }
        public string rating { get; set; }
        public string special_features { get; set; }
        public string last_update { get; set; }
                
        public List<FilmActorDto>? filmActors { get; set; }

    }
}
