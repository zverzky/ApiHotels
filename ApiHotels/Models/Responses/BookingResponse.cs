namespace ApiHotels.Models.Responses
{
    public class BookingResponse
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid UserId { get; set; }
        public Guid HotelId { get; set; }
    }
}
