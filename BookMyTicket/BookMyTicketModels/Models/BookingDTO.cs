namespace BookMyTicketServices.Modals
{
    public class BookingDTO
    {
        public int BookingId { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime TimeOfBooking { get; set; }
        public int UserId { get; set; }
    }
}
