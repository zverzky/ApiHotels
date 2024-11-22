using ApiHotels.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Interfaces
{
    public interface IHotelsRepository
    {
        Task<Hotel> GetHotelById(int id);
        IEnumerable<User> GetAllHotels();
        void UpdateHotel(User user);

    }
}
