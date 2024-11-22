using ApiHotels.DAL.Entities;
using ApiHotels.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApiHotels.Infrastructure.Repositories
{
    public class BookingRepository: IBookingRepository
    {
        Task<Booking> IBookingRepository.GetBookingById(int id)
        {
            throw new NotImplementedException();
        }

        void IBookingRepository.CreateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        void IBookingRepository.UpdateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        void IBookingRepository.DeleteBookingr(int id)
        {
            throw new NotImplementedException();
        }
    }
}
