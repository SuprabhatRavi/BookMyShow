using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface IMovieGenreServices
    {
        GenreDTO AddGenre(GenreDTO genre);
        void DeleteGenre(int id);
        GenreDTO GetGenreById(int id);
        IEnumerable<GenreDTO> GetGenreList();
        GenreDTO UpdateGenreDetails(int id, GenreDTO genre);
    }
}