using ApiHotels.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.DAL.Interfaces
{
    public interface IRoomRepository
    {
        Task<Room> GetRoomById(int id);
        IEnumerable<Room> GetAllRooms();

    }
}
