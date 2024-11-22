using ApiHotels.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Interfaces
{
    public interface IBookingRepository
    {
        Task<Booking> GetBookingById(int id);
        void CreateBooking(Booking booking);
        void UpdateBooking(Booking booking);
        void DeleteBookingr(int id);
    }
}
