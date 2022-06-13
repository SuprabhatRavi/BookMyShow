using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface IMovieServices
    {
        GenreDTO AddMovie(GenreDTO movie);
        void DeleteMovie(int id);
        MovieDTO GetMovieById(int id);
        IEnumerable<MovieDTO> GetMovieList();
        MovieDTO UpdateMovieDetails(int id, MovieDTO movie);
        public IEnumerable<MovieDTO> GetPage(int PageNumber);
    }
}