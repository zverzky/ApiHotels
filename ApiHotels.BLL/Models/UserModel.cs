using ApiHotels.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.BLL.Models;

public class UserModel
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; }

    // Навигационное свойство для связи с Booking
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
