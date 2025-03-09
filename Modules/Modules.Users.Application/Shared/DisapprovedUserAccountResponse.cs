using System;
namespace Modules.Users.Application.Shared;

public record DisapprovedUserAccountSuccessResponseDto : BaseResponse { };
public record DisapprovedUserAccountErrorResponseDto : BaseResponse { };


public class DisapprovedUserAccountResponseDto
{
    public bool IsSuccess { get; set; }
    public DisapprovedUserAccountSuccessResponseDto? SuccessResponse { get; set; }
    public DisapprovedUserAccountErrorResponseDto? ErrorResponse { get; set; }
}

