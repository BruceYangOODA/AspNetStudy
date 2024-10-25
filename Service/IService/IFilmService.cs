using AspNetStudy.Models;

namespace AspNetStudy.Service.IService
{
    public interface IFilmService
    {
        public List<FilmDto> getFilms();
    }
}
