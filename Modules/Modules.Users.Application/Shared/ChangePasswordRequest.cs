using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{
	public record ChangePasswordRequest
	{
        [StringLength(36)]
        public required string UserId { get; set; }

        public required string OldPassword { get; set; }

        public required string NewPassword { get; set; }

        public required string ConfirmNewPassword { get; set; }
    }
}

