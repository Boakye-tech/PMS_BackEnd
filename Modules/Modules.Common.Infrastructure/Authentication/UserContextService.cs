// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System;
using System.Linq;
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
                   ?? user?.FindFirst("nameid")?.Value;
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

        public string? UserCode()
        {
            //var user = _httpContextAccessor.HttpContext?.User;
            //var primarySid = user?.Claims.FirstOrDefault(c => c.Type.EndsWith("primarysid", StringComparison.OrdinalIgnoreCase))?.Value;

            //return primarySid;

            var user = _httpContextAccessor.HttpContext?.User;
            return user?.FindFirst(ClaimTypes.PrimarySid)?.Value
                   ?? user?.FindFirst("primarysid")?.Value;
        }
    }
}

