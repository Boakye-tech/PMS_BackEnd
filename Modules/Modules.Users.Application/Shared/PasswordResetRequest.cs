using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
	public record PasswordResetRequest
    {
        public required string Phone_OR_Email { get; set; }

        [StringLength(6)]
        public required string Token { get; set; }

        public required string NewPassword { get; set; }

        public required string ConfirmNewPassword { get; set; }
    }
}

