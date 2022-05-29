using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public interface IShowServices
    {
        ShowDTO AddShow(ShowDTO show);
        void DeleteShow(int id);
        ShowDTO GetShowById(int id);
        IEnumerable<ShowDTO> GetShowList();
        ShowDTO UpdateShowDetails(int id, ShowDTO show);
    }
}