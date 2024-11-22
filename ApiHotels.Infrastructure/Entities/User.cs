using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public DateTime BrithDate { get; set; }

        // Навигационное свойство для связи с Booking
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
