using AspNetStudy.Database;

namespace AspNetStudy.Repository
{
    public class BaseRepository<T> where T : BaseRepository<T>
    {
        //protected readonly IConfiguration _configuration;
        protected readonly SakilaContext _context;
        //protected readonly string _connectStringJpmedRWD;
        //protected readonly string _connectStringAIShelves;
        //protected ILogger<T> _logger;
        public BaseRepository(SakilaContext context)
        {
           // _configuration = configuration;
            _context = context;
            //_connectStringJpmedRWD = _configuration.GetConnectionString("JpmedRWDMysql");
            //_connectStringAIShelves = _configuration.GetConnectionString("AIShelvesMysql");
           // _logger = logger;
        }
    }
}
