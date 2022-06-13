using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IShowTicketServices Services;

        public TicketController(IShowTicketServices services)
        {
            Services = services;
        }

        [HttpGet("{id}")]
        public IEnumerable<TicketDTO> GetContact(int id)
        {
            return Services.GetTicketById(id);
        }
    }
}
