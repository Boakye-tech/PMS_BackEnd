using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{

	public record ResetPasswordSuccessResponse : BaseResponse
	{
    }

    public record ResetPasswordErrorResponse : BaseResponse
    {
    }

    public record ResetPasswordResponse
    {
        public bool IsSuccess { get; set; }
        public ResetPasswordSuccessResponse? SuccessResponse { get; set; }
        public ResetPasswordErrorResponse? ErrorResponse { get; set; }
    }

}

