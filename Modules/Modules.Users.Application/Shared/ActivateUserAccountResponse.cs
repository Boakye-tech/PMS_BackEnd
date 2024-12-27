using System;
namespace Modules.Users.Application.Shared
{
    public record ActivateUserAccountSuccessResponseDto : BaseResponse { };
    public record ActivateUserAccountErrorResponseDto : BaseResponse { };

    public class ActivateUserAccountResponseDto
    {
        public bool IsSuccess { get; set; }
        public ActivateUserAccountSuccessResponseDto? SuccessResponse { get; set; }
        public ActivateUserAccountErrorResponseDto? ErrorResponse { get; set; }
    }

}

