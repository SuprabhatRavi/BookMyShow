using AutoMapper;
using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public class BookingServices : IBookingServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public BookingServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }
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
    }
}
