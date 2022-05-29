using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface IBookingServices
    {
        BookingDTO AddBooking(BookingDTO booking);
        void DeleteBooking(int id);
        BookingDTO GetBookingById(int id);
        IEnumerable<BookingDTO> GetBookingList();
        BookingDTO UpdateBookingDetails(int id, BookingDTO booking);
    }
}