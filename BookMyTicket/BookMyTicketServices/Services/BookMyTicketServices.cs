using AutoMapper;
using BookMyTicketServices.Modals;
//using Microsoft.AspNetCore.Mvc;

namespace BookMyTicketServices.Services
{
    public class BookMyTicketServices : IBookMyTicketServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public BookMyTicketServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }

        //For Users
        public UsersDTO AddUser(UsersDTO user)
        {
            db.Insert("Users", "UserId", true, user);
            return user;
        }

        public void DeleteUser(int id)
        {
            Users UserDetails = db.Single<Users>($"Select * from users where UserId = {id}");
            db.Delete("Users", "UserId", UserDetails);
        }

        public UsersDTO GetUserById(int id)
        {
            Users UserDetails = db.Single<Users>($"Select * from users where UserId = {id}");
            return Mapper.Map<UsersDTO>(UserDetails);
        }

        public IEnumerable<UsersDTO> GetUserList()
        {
            var UserList = db.Query<Users>("Select * from users");
            return Mapper.Map<IEnumerable<UsersDTO>>(UserList);
        }

        public UsersDTO UpdateUserDetails(int id, UsersDTO user)
        {
            if (id == user.UserId)
            {
                db.Update("Users", "UserId", user);
            }
            return user;
        }

        //For Booking
        public IEnumerable<BookingDTO> GetBookingList()
        {
            var BookingList = db.Query<Booking>("Select * from Booking");
            return Mapper.Map<IEnumerable<BookingDTO>>(BookingList);
        }

        public BookingDTO GetBookingById(int id)
        {
            var BookingDetails = db.Single<Booking>($"Select * from Booking where BookingId = {id}");
            return Mapper.Map<BookingDTO>(BookingDetails);
        }

        public BookingDTO AddBooking(BookingDTO booking)
        {
            db.Insert("Booking", "BookingId", true, booking);
            return booking;
        }

        public BookingDTO UpdateBookingDetails(int id, BookingDTO booking)
        {
            if (id == booking.BookingId)
            {
                db.Update("Booking", "BookingId", booking);
            }
            return booking;
        }

        public void DeleteBooking(int id)
        {
            var BookingDetails = db.Single<Booking>($"Select * from Booking where BookingId = {id}");
            db.Delete("Booking", "BookingId", BookingDetails);
        }

        //For Genre
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

        //For Movie
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

        //For Seat
        public IEnumerable<SeatDTO> GetSeatList()
        {
            var SeatList = db.Query<Movie>("Select * from Seat");
            return Mapper.Map<IEnumerable<SeatDTO>>(SeatList);
        }

        public SeatDTO GetSeatById(int id)
        {
            var SeatDetails = db.Single<Seat>($"Select * from Seat where SeatId = {id}");
            return Mapper.Map<SeatDTO>(SeatDetails);
        }

        public SeatDTO AddSeat(SeatDTO seat)
        {
            db.Insert("Seat", "SeatId", true, seat);
            return seat;
        }

        public SeatDTO UpdateSeatDetails(int id, SeatDTO seat)
        {
            if (id == seat.SeatId)
            {
                db.Update("Seat", "SeatId", seat);
            }
            return seat;
        }

        public void DeleteSeat(int id)
        {
            var SeatDetails = db.Single<Seat>($"Select * from Seat where SeatId = {id}");
            db.Delete("Seat", "SeatId", SeatDetails);
        }

        //For Show
        public IEnumerable<ShowDTO> GetShowList()
        {
            var ShowList = db.Query<Show>("Select * from Show");
            return Mapper.Map<IEnumerable<ShowDTO>>(ShowList);
        }

        public ShowDTO GetShowById(int id)
        {
            var ShowDetails = db.Single<Movie>($"Select * from Show where ShowId = {id}");
            return Mapper.Map<ShowDTO>(ShowDetails);
        }

        public ShowDTO AddShow(ShowDTO show)
        {
            db.Insert("Show", "ShowId", true, show);
            return show;
        }

        public ShowDTO UpdateShowDetails(int id, ShowDTO show)
        {
            if (id == show.ShowId)
            {
                db.Update("Show", "ShowId", show);
            }
            return show;
        }

        public void DeleteShow(int id)
        {
            var ShowDetails = db.Single<Movie>($"Select * from Show where ShowId = {id}");
            db.Delete("Show", "ShowId", ShowDetails);
        }


    }
}
