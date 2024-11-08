using ApiHotels.Models.Requests;
using ApiHotels.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotels.Controllers;

[Route("api/Hotels")]
[ApiController]
public class HotelsController : Controller
{
    [HttpPost]
    public ActionResult<Guid> HotelAdd([FromBody] HotelAddRequest request)
    {
        var last = new Guid();
        return Ok(last);
    }
    [HttpPut("{id}")]
    public IActionResult HotelUpdate([FromRoute] Guid id, [FromBody] HotelUpdateRequest request)
    {
        return NoContent();
    }
    [HttpGet("{id}")]
    public ActionResult<HotelResponse> GetHotel([FromRoute] Guid id)
    {
        var user = new UserWithResponse();
        return Ok(user);
    }
    [HttpGet]
    public ActionResult<List<HotelResponse>> GetHotels()
    {

        return Ok();
    }
    [HttpDelete("{id}")]
    public ActionResult DeleteHotel([FromRoute] Guid id)
    {
        return NoContent();
    }
}
