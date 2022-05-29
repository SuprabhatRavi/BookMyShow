using AutoMapper;
using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public class SeatServices : ISeatServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public SeatServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }
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
    }
}
