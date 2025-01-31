using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
	public record LoginRequestDto
    {
        public required string Phone_OR_Email { get; set; }
        public required string Password { get; set; }
    }
}

