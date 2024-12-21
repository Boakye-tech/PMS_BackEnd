using System;
namespace Modules.Users.Application.Shared
{
    public record LoginResponse
    {
        public required string UserId { get; set; }
        public required string FullName { get; set; }
        public required string EmailAddress { get; set; }
        public required string BearerToken { get; set; }
    }
}

