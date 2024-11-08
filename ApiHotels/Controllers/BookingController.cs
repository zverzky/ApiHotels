using ApiHotels.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotels.Controllers;

[Route("api/Booking")]
[ApiController]
public class BookingController : Controller
{
    [HttpPost]
    public ActionResult<Guid> bookingAdd([FromBody] BookingRequest request)
    {
        var last = new Guid();
        return Ok(last);
    }
    [HttpDelete("{Id}")]
    public ActionResult BookingDelete([FromRoute] Guid Id)
    {
        return NoContent();
    }
}