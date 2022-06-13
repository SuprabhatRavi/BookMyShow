using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface IShowTicketServices
    {
        IEnumerable<TicketDTO> GetTicketById(int id);
    }
}