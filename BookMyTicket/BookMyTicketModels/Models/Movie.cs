using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required, MaxLength(20)]
        public string MovieName { get; set; }
        [Required]
        public DateTime MovieDuration { get; set; }
        [Required, MaxLength(20)]
        public string MovieLanguage { get; set; }
    }
}
