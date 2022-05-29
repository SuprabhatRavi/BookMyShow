namespace BookMyTicketServices.Modals
{
    public class SeatDTO
    {
        public int SeatId { get; set; }
        public int Price { get; set; }
        public int SeatNumber { get; set; }
        public int MovieHallId { get; set; }
        public int BookingId { get; set; }
    }
}
