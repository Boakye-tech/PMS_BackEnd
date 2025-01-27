using System;
namespace Modules.Users.Application.Dtos.Entities
{

    public record RefreshTokenRequestDto
    {
        public required string BearerToken { get; set; }
        public required string RefreshToken { get; set; }
    }

    public record RefreshTokenResponseDto
	{
		public string? UserId { get; set; }
		public string? BearerToken { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? ExpiresAt { get; set; }
	}
}

