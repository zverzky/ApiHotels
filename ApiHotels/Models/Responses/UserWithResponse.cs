namespace ApiHotels.Models.Responses
{
    public class UserWithResponse : UserResponse
    {
        public bool RememberMe { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
