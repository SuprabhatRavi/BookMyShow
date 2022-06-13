using AutoMapper;

namespace BookMyTicketServices.Modals
{
    public class MappingEntity: Profile
    {
        public MappingEntity()
        {
            CreateMap<Booking, BookingDTO>();
            CreateMap<Genre, GenreDTO>();
            CreateMap<Movie, MovieDTO>();
            CreateMap<MovieHall, MovieHallDTO>();
            CreateMap<Seat, SeatDTO>();
            CreateMap<Show, ShowDTO>();
            CreateMap<Users, UsersDTO>();
            CreateMap<Ticket, TicketDTO>();
        }
    }
}
