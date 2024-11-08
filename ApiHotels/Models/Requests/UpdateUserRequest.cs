namespace ApiHotels.Models.Requests
{
    public class UpdateUserRequest
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public DateTime BrithDate { get; set; }

    }
}
