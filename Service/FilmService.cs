using AspNetStudy.Service.IService;
using AspNetStudy.Repository.IRepository;
using AspNetStudy.Repository;
using AspNetStudy.Models;
using Microsoft.Extensions.Logging;

namespace AspNetStudy.Service
{
    public class FilmService : BaseService<FilmService>, IFilmService
    {
        private readonly IFilmRepository _filmRepository;
        public FilmService(IFilmRepository filmRepository) : base()
        {
            _filmRepository = filmRepository;
        }

        public List<FilmDto> getFilms() {
            return _filmRepository.getAllFilms();
        }
    }
}
