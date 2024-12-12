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
        //if (user is null)
        //{
        //    return BadRequest("Invalid client request");
        //}
        //if (user.Email == "johndoe@mail.ru" && user.Password == "def@123")
        //{
        //    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
        //    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        //    var tokeOptions = new JwtSecurityToken(
        //        issuer: "https://localhost:5001",
        //        audience: "https://localhost:5001",
        //        claims: new List<Claim>(),
        //        expires: DateTime.Now.AddMinutes(5),
        //        signingCredentials: signinCredentials
        //    );
        //    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
        //    return Ok(new AuthenticatedResponse { Token = tokenString });
        //}
        //return Unauthorized();
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