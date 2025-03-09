using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{

	public record RegistrationSuccessResponse : BaseResponse
	{
        public required string UserId { get; set; }

        public required string UserEmailAddress { get; set; }
    }

    public record RegistrationErrorResponse : BaseResponse
    {
    }

    public record RegistrationResponse
    {
        public bool IsSuccess { get; set; }
        public RegistrationSuccessResponse? SuccessResponse { get; set; }
        public RegistrationErrorResponse? ErrorResponse { get; set; }
    }

}

