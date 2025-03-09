using System;
namespace Modules.Users.Application.Shared;

public record ApproveUserAccountSuccessResponseDto : BaseResponse { };
public record ApproveUserAccountErrorResponseDto : BaseResponse { };

public class ApproveUserAccountResponseDto
{
    public bool IsSuccess { get; set; }
    public ApproveUserAccountSuccessResponseDto? SuccessResponse { get; set; }
    public ApproveUserAccountErrorResponseDto?  ErrorResponse { get; set; }
}

