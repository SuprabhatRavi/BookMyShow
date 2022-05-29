using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyTicketServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices Services;

        public MovieController(IMovieServices services)
        {
            Services = services;
        }
        [HttpGet]
        public IEnumerable<MovieDTO> GetMovieList()
        {
            return Services.GetMovieList();
        }
        [HttpGet("{id}")]
        public MovieDTO GetMovieById(int id)
        {
            return Services.GetMovieById(id);
        }
        [HttpPost]
        public GenreDTO AddMovie(GenreDTO movie)
        {
            return Services.AddMovie(movie);
        }
        [HttpPatch]
        public MovieDTO UpdateMovieDetails(int id, MovieDTO movie)
        {
            return Services.UpdateMovieDetails(id, movie);
        }
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            Services.DeleteMovie(id);
        }
    }
}
