using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required, MaxLength(20)]
        public string GenereName { get; set; }
        [Required]
        public int MovieId { get; set; }
    }
}
