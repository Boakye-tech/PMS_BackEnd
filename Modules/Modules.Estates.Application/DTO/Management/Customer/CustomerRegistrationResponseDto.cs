using System;
namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record CustomerRegistrationResponseDto
	{
        public bool IsSuccess { get; set; }
        public CustomerRegistrationSuccessResponseDto? SuccessResponse { get; set; }
        public BaseResponseDto? ErrorResponse { get; set; }
    }
}

