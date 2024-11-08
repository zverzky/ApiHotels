using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ApiHotels.Models.Requests;
using ApiHotels.Models.Responses;

namespace SampleBackend.Controllers;



[Route("api/users")]
[ApiController]
public class UsersController : Controller
{
    [HttpPost]
    public ActionResult<Guid> Register([FromBody] RegisterUserRequest request)
    {
        var last = new Guid();
        return Ok(last);
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] ApiHotels.Models.Requests.LoginRequest request)
    {
        return Ok();
    }
    [HttpGet("{id}")]
    public ActionResult<UserWithResponse> GetIserById([FromRoute] Guid id)
    {
        var user = new UserWithResponse();
        return Ok(user);
    }
    [HttpGet]
    public ActionResult<List<UserResponse>> GetUsers()
    {

        return Ok();
    }
    [HttpPut("{id}")]
    public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserRequest request)
    {
        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteUser([FromRoute] Guid id)
    {
        return NoContent();
    }
    [HttpPatch("{id}/Diactivate)")]
    public IActionResult Diactivate([FromRoute] Guid id)
    {
        return NoContent();
    }
}