using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Entities
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Type { get; set; }  
        public decimal Price { get; set; }
        public bool Availability { get; set; }
        public Guid HotelId { get; set; }

        // Навигационное свойство для связи с Hotel
        public Hotel Hotel { get; set; }
    }
}
