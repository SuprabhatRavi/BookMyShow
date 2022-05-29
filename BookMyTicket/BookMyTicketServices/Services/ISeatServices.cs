using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface ISeatServices
    {
        SeatDTO AddSeat(SeatDTO seat);
        void DeleteSeat(int id);
        SeatDTO GetSeatById(int id);
        IEnumerable<SeatDTO> GetSeatList();
        SeatDTO UpdateSeatDetails(int id, SeatDTO seat);
    }
}