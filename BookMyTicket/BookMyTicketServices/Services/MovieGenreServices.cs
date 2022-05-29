using AutoMapper;
using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public class MovieGenreServices : IMovieGenreServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public MovieGenreServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }
        public IEnumerable<GenreDTO> GetGenreList()
        {
            var GenreList = db.Query<Genre>("Select * from Booking");
            return Mapper.Map<IEnumerable<GenreDTO>>(GenreList);
        }

        public GenreDTO GetGenreById(int id)
        {
            var GenreDetails = db.Single<Genre>($"Select * from Genre where GenreId = {id}");
            return Mapper.Map<GenreDTO>(GenreDetails);
        }

        public GenreDTO AddGenre(GenreDTO genre)
        {
            db.Insert("Genre", "GenreId", true, genre);
            return genre;
        }

        public GenreDTO UpdateGenreDetails(int id, GenreDTO genre)
        {
            if (id == genre.GenreId)
            {
                db.Update("Genre", "GenreId", genre);
            }
            return genre;
        }

        public void DeleteGenre(int id)
        {
            var GenreDetails = db.Single<Genre>($"Select * from Genre where GenreId = {id}");
            db.Delete("Genre", "GenreId", GenreDetails);
        }
    }
}
