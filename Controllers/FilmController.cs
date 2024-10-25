using AspNetStudy.Models;
using AspNetStudy.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AspNetStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;

        public FilmController(IFilmService filmService) {
            _filmService = filmService;
        }
        [HttpGet]
        //[SwaggerResponse(200, "Success", typeof(List<FilmDto>))]
       // [SwaggerResponse(400, "Bad Request", typeof(string))]
       // [SwaggerResponse(404, "Not Found", typeof(string))]
        public List<FilmDto> getAllFilms() 
        {
            try 
            {
                List<FilmDto> films = _filmService.getFilms();
                return films;
            }
            catch(Exception e) { throw; }
        }
    }
}
