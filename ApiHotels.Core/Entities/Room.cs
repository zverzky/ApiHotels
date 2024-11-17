using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.Core.Entities
{
    public class Room
    {
        public Guid Id { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
        public Boolean availability { get; set; }
        public Guid HotelId { get; set; }
    }
}
