using ApiHotels.Core.Entities;
using ApiHotels.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public IEnumerable<Room> GetAllRooms()
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
