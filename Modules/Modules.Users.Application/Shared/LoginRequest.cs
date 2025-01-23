using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
	public record LoginRequest
    {
        //public required string Phone_OR_Email { get; set; }
        public required string Password { get; set; }
    }
}

