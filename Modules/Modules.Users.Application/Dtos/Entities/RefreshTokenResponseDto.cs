using System;
namespace Modules.Users.Application.Dtos.Entities
{

    public record RefreshTokenRequestDto
    {
        public required string BearerToken { get; set; }
        public required string RefreshToken { get; set; }
    }

    public record RefreshTokenSuccessResponseDto
	{
		public string? UserId { get; set; }
		public string? BearerToken { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? ExpiresAt { get; set; }
	}

    public record RefreshTokenErrorResponseDto : BaseResponse { };

    public class RefreshTokenResponseDto
    {
        public bool IsSuccess { get; set; }
        public RefreshTokenSuccessResponseDto? SuccessResponse { get; set; }
        public RefreshTokenErrorResponseDto? ErrorResponse { get; set; }
    }

}

