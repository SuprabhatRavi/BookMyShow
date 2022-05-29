using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int SeatNumber { get; set; }
        [Required]
        public int MovieHallId { get; set; }
        [Required]
        public int BookingId { get; set; }
    }
}
