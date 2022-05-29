using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public int NumberOfSeats { get; set; }
        [Required]
        public DateTime TimeOfBooking { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
