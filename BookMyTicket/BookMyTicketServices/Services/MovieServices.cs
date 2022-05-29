using AutoMapper;
using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public class MovieServices : IMovieServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public MovieServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }
        public IEnumerable<MovieDTO> GetMovieList()
        {
            var MovieList = db.Query<Movie>("Select * from Movie");
            return Mapper.Map<IEnumerable<MovieDTO>>(MovieList);
        }

        public MovieDTO GetMovieById(int id)
        {
            var MovieDetails = db.Single<Movie>($"Select * from Movie where MovieId = {id}");
            return Mapper.Map<MovieDTO>(MovieDetails);
        }

        public GenreDTO AddMovie(GenreDTO movie)
        {
            db.Insert("Movie", "MovieId", true, movie);
            return movie;
        }

        public MovieDTO UpdateMovieDetails(int id, MovieDTO movie)
        {
            if (id == movie.MovieId)
            {
                db.Update("Movie", "MovieId", movie);
            }
            return movie;
        }

        public void DeleteMovie(int id)
        {
            var MovieDetails = db.Single<Movie>($"Select * from Movie where MovieId = {id}");
            db.Delete("Movie", "MovieId", MovieDetails);
        }
    }
}
