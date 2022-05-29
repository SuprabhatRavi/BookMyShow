using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface IBookMyTicketServices
    {
        BookingDTO AddBooking(BookingDTO booking);
        GenreDTO AddGenre(GenreDTO genre);
        GenreDTO AddMovie(GenreDTO movie);
        SeatDTO AddSeat(SeatDTO seat);
        ShowDTO AddShow(ShowDTO show);
        UsersDTO AddUser(UsersDTO user);
        void DeleteBooking(int id);
        void DeleteGenre(int id);
        void DeleteMovie(int id);
        void DeleteSeat(int id);
        void DeleteShow(int id);
        void DeleteUser(int id);
        BookingDTO GetBookingById(int id);
        IEnumerable<BookingDTO> GetBookingList();
        GenreDTO GetGenreById(int id);
        IEnumerable<GenreDTO> GetGenreList();
        MovieDTO GetMovieById(int id);
        IEnumerable<MovieDTO> GetMovieList();
        SeatDTO GetSeatById(int id);
        IEnumerable<SeatDTO> GetSeatList();
        ShowDTO GetShowById(int id);
        IEnumerable<ShowDTO> GetShowList();
        UsersDTO GetUserById(int id);
        IEnumerable<UsersDTO> GetUserList();
        BookingDTO UpdateBookingDetails(int id, BookingDTO booking);
        GenreDTO UpdateGenreDetails(int id, GenreDTO genre);
        MovieDTO UpdateMovieDetails(int id, MovieDTO movie);
        SeatDTO UpdateSeatDetails(int id, SeatDTO seat);
        ShowDTO UpdateShowDetails(int id, ShowDTO show);
        UsersDTO UpdateUserDetails(int id, UsersDTO user);
    }
}