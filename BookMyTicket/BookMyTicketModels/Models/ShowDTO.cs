namespace BookMyTicketServices.Modals
{
    public class ShowDTO
    {
        public int ShowId { get; set; }
        public DateTime ShowDate { get; set; }
        public DateTime ShowStartTime { get; set; }
        public DateTime ShowEndTime { get; set; }
        public int MovieId { get; set; }
        public int MovieHallId { get; set; }
    }
}
