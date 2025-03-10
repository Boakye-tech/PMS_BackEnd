using System;
namespace Modules.Estates.Application.DTO
{
	public record BaseResponseDto
	{
        public required int StatusCode { get; set; }

        public required string StatusMessage { get; set; }
    }
}

