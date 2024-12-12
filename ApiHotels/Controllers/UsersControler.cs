using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ApiHotels.Models.Requests;
using ApiHotels.Models.Responses;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using ApiHotels.BLL.Configuration;
using ApiHotels.Models.Role;
using ApiHotels.BLL.Models;

namespace SampleBackend.Controllers;



[Route("api/users")]
[Authorize]
[ApiController]
public class UsersController : Controller
{
    [HttpPost]
    public ActionResult<Guid> Register([FromBody] RegisterUserRequest request)
    {
        var last = new Guid();
        return Ok(last);
    }
    [AllowAnonymous]
    [HttpPost("login")]
    public IActionResult Login([FromBody] UserLoginModel user)
    {
        return Ok(user);
    }
    [HttpGet("{id}")]
    public ActionResult<UserWithResponse> GetUserById([FromRoute] Guid id)
    {
        var user = new UserWithResponse();
        return Ok(user);
    }
    [HttpGet]
    [CastomAuthorize([UserRole.User, UserRole.Admin])]
    public ActionResult<List<UserResponse>> GetUsers()
    {
        var users = new List<UserResponse>
    {
        new UserResponse { id = Guid.NewGuid() },
        new UserResponse { id = Guid.NewGuid() },
        new UserResponse { id = Guid.NewGuid() }
    };

        return Ok(users);
    }
}