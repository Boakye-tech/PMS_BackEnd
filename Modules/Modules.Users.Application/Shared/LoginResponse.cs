using System;
namespace Modules.Users.Application.Shared
{
    public abstract record LoginResponse
    {
        public required string UserId { get; set; }
        public bool IsFirstTime { get; set; }
        public required string BearerToken { get; set; }
        public required string RefreshToken { get; set; }
        public DateTime? ExpiresAt { get; set; }

    }
}

