using System;
namespace Modules.Users.Application.Shared
{
	public record LoginRequest
    {
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
    }
}

