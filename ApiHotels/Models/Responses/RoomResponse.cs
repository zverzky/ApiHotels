namespace ApiHotels.Models.Responses
{
    public class RoomResponse
    {
        public Guid Id { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
        public Boolean availability { get; set; }
        public Guid HotelId { get; set; }
    }
}
