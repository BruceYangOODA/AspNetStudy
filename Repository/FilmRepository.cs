using AspNetStudy.Database;
using AspNetStudy.Models;
using AspNetStudy.Repository.IRepository;

namespace AspNetStudy.Repository
{
    public class FilmRepository: BaseRepository<FilmRepository>, IFilmRepository
    {
        protected readonly SakilaContext _context;
        public FilmRepository(SakilaContext context) : base(context) {
            _context = context;
        }
    

        public List<FilmDto> getAllFilms() {

            return _context.Films.ToList();
        }

    }
}
