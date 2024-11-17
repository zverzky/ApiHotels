using ApiHotels.Core.Entities;
using ApiHotels.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.Infrastructure.Repositories
{
    public class HotelRepository : IHotelsRepository
    {

        public IEnumerable<User> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetHotelById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateHotel(User user)
        {
            throw new NotImplementedException();
        }
    }
}
