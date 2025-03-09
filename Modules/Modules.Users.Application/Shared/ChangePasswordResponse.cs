using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Shared
{

	public record ChangePasswordSuccessResponse : BaseResponse
	{
    }

    public record ChangePasswordErrorResponse : BaseResponse
    {
    }

    public class ChangePasswordResponse
    {
        public bool IsSuccess { get; set; }
        public ChangePasswordSuccessResponse? SuccessResponse { get; set; }
        public ChangePasswordErrorResponse? ErrorResponse { get; set; }
    }

}

