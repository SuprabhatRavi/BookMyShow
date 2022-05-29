using BookMyTicketServices.Modals;
using BookMyTicketServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyTicketServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices Services;

        public BookingController(IBookingServices services)
        {
            Services = services;
        }


        [HttpGet]
        public IEnumerable<BookingDTO> GetBookingList()
        {
            return Services.GetBookingList();
        }
        [HttpGet("{id}")]
        public BookingDTO GetBookingById(int id)
        {
            return Services.GetBookingById(id);
        }
        [HttpPost]
        public BookingDTO AddBooking(BookingDTO booking)
        {
            return Services.AddBooking(booking);
        }
        [HttpPatch]
        public BookingDTO UpdateBookingDetails(int id, BookingDTO booking)
        {
            return Services.UpdateBookingDetails(id, booking);
        }
        [HttpDelete]
        public void DeleteBooking(int id)
        {
            Services.DeleteBooking(id);
        }
    }
}
