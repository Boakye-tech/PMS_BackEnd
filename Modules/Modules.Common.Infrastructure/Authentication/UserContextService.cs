using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Modules.Common.Infrastructure.Authentication
{
	public class UserContextService : IUserContextService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserContextService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? GetUserId()
        {
            //throw new NotImplementedException();
            var user = _httpContextAccessor.HttpContext?.User;
            return user?.FindFirst(ClaimTypes.NameIdentifier)?.Value
                   ?? user?.FindFirst("sub")?.Value;
        }

        public bool? GetUserRole(string roleName)
        {
            return _httpContextAccessor.HttpContext?.User.IsInRole(roleName);
        }

        public string? GetAccessToken()
        {
            var authHeader = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].ToString();
            if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer "))
            {
                return authHeader.Substring("Bearer ".Length);
            }

            return null;
        }
    }
}

