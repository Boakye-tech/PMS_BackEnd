using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
	public record ResetPasswordRequest
    {
        [EmailAddress]
        public string? EmailAddress { get; set; }
        public required int Token { get; set; }
        public required string NewPassword { get; set; }
        public required string ConfirmNewPassword { get; set; }
    }
}

