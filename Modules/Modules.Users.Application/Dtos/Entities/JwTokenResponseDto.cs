using System;
namespace Modules.Users.Application.Dtos.Entities
{
	public record JwTokenResponseDto
	{
        public string? Token { get; set; }
        public string? UserType { get; set; }

    }
}

