using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Entities
{
    public class Hotel
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Adress { get; set; }

        // Навигационное свойство для связи с Booking
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        // Навигационное свойство для связи с Room
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
