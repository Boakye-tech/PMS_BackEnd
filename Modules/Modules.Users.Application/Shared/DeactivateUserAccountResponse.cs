using System;
namespace Modules.Users.Application.Shared;

public record DeactivateUserAccountSuccessResponseDto : BaseResponse { };
public record DeactivateUserAccountErrorResponseDto : BaseResponse { };

public class DeactivateUserAccountResponseDto
{
    public bool IsSuccess { get; set; }
    public DeactivateUserAccountSuccessResponseDto? SuccessResponse { get; set; }
    public DeactivateUserAccountErrorResponseDto? ErrorResponse { get; set; }
}

