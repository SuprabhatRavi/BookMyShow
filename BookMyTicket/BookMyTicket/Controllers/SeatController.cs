using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyTicketServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly ISeatServices Services;
        public SeatController(ISeatServices services)
        {
            Services = services;
        }

        [HttpGet]
        public IEnumerable<SeatDTO> GetSeatList()
        {
            return Services.GetSeatList();
        }
        [HttpGet("{id}")]
        public SeatDTO GetSeatById(int id)
        {
            return Services.GetSeatById(id);
        }
        [HttpPost]
        public SeatDTO AddSeat(SeatDTO seat)
        {
            return Services.AddSeat(seat);
        }
        [HttpPatch]
        public SeatDTO UpdateSeatDetails(int id, SeatDTO seat)
        {
            return Services.UpdateSeatDetails(id, seat);
        }
        [HttpDelete]
        public void DeleteSeat(int id)
        {
            Services.DeleteSeat(id);
        }
    }
}
