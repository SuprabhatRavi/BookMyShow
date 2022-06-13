using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class Ticket
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public int BookingId { get; set; }
        public int SeatNumber { get; set; }
        public DateTime ShowDate { get; set; }
        public DateTime ShowStartTime { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieDuration { get; set; }

    }
}
