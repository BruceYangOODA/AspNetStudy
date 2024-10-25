using AspNetStudy.Models;

namespace AspNetStudy.Repository.IRepository
{
    public interface IFilmRepository
    {
        public List<FilmDto> getAllFilms();
    }
}
