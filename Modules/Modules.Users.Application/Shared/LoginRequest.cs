using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
	public record LoginRequest
    {
        [EmailAddress]
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
    }
}

