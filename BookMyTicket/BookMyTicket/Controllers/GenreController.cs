using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyTicketServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IMovieGenreServices Services;

        public GenreController(IMovieGenreServices services)
        {
            Services = services;
        }

        [HttpGet]
        public IEnumerable<GenreDTO> GetGenreList()
        {
            return Services.GetGenreList();
        }
        [HttpGet("{id}")]
        public GenreDTO GetGenreById(int id)
        {
            return Services.GetGenreById(id);
        }
        [HttpPost]
        public GenreDTO AddGenre(GenreDTO genre)
        {
            return Services.AddGenre(genre);
        }
        [HttpPatch]
        public GenreDTO UpdateGenreDetails(int id, GenreDTO genre)
        {
            return Services.UpdateGenreDetails(id, genre);
        }
        [HttpDelete]
        public void DeleteGenre(int id)
        {
            Services.DeleteGenre(id);
        }
    }
}
