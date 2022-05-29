using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class MovieHall
    {
        [Key]
        public int MovieHallId { get; set; }
        [Required]
        public int TotalSeats { get; set; }
    }
}
