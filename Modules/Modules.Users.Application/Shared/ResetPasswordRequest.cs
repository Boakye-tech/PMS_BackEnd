using System;
namespace Modules.Users.Application.Shared
{
	public record ResetPasswordRequest
    {
        public string? EmailAddress { get; set; }
        public required int Token { get; set; }
        public required string NewPassword { get; set; }
        public required string ConfirmNewPassword { get; set; }
    }
}

