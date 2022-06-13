using AutoMapper;
using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public class ShowTicketServices : IShowTicketServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public ShowTicketServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }

        public IEnumerable<TicketDTO> GetTicketById(int id)
        {
            var TicketDetails = db.Query<Ticket>($";EXEC GetTicket @@UId = { id }");
            return Mapper.Map<IEnumerable<TicketDTO>>(TicketDetails);
        }
    }
}
