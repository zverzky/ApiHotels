using ApiHotels.BLL.Models;
using ApiHotels.DAL.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using ApiHotels.Infrastructure.Repositories;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.BLL
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ApiHotels.Models.Responses.AuthenticatedResponse> Login(UserLoginModel user)
        {
            if (user is null)
            {
                throw new ArgumentException("Invalid client request");
            }
            if (user.Email == "johndoe@mail.ru" && user.Password == "def@123")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken(
                    issuer: "https://localhost:5001",
                    audience: "https://localhost:5001",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return new ApiHotels.Models.Responses.AuthenticatedResponse { Token = tokenString };
            }
            return null; 
        }
    }
}