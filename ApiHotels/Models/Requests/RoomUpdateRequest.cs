namespace ApiHotels.Models.Requests
{
    public class RoomUpdateRequest
    {
        public string type { get; set; }
        public decimal price { get; set; }
        public Boolean availability { get; set; }
    }
}
