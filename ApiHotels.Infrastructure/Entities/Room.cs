using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Entities
{
    public class Room
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Type { get; set; }
        public decimal Price { get; set; }
        
        public bool Availability { get; set; } = true;
        public Guid HotelId { get; set; }

        public Hotel Hotel { get; set; }
    }
}
