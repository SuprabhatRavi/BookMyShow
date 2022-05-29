using System.ComponentModel.DataAnnotations;

namespace BookMyTicketServices.Modals
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required, MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string PhoneNumber { get; set; }
    }
}
