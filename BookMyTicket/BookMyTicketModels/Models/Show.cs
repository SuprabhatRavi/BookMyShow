using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
        [Required]
        public DateTime ShowDate { get; set; }
        [Required]
        public DateTime ShowStartTime { get; set; }
        [Required]
        public DateTime ShowEndTime { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int MovieHallId { get; set; }

    }
}
