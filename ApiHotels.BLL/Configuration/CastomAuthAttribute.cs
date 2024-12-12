using ApiHotels.Models.Role;
using Microsoft.AspNetCore.Authorization;

namespace ApiHotels.BLL.Configuration
{
    public class CastomAuthorizeAttribute : AuthorizeAttribute
    {
        public CastomAuthorizeAttribute(params UserRole[] roles)
        {
            
            Roles = string.Join(',', roles);
        }
    }
}