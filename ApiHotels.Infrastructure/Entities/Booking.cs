using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid UserId { get; set; }
        public Guid HotelId { get; set; }

        // Навигационные свойства
        public User User { get; set; }
        public Hotel Hotel { get; set; }
    }
}
