namespace ApiHotels.Models.Requests
{
    public class HotelAddRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
