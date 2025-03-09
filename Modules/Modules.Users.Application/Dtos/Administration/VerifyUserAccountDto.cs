using System;
namespace Modules.Users.Application.Dtos.Administration;

public record VerifyUserAccountDto(string UserId, string verifiedBy); //: ConfirmUserAccountDto();
public record RejectUserAccountDto(string UserId, string RejectedBy, string RejectedReasons); // : ConfirmUserAccountDto();

public record CustomerVerificationSuccessResponseDto : BaseResponse { };
public record CustomerVerificationErrorResponseDto : BaseResponse { };

public record CustomerRejectionSuccessResponseDto : BaseResponse { };
public record CustomerRejectionErrorResponseDto : BaseResponse { };



public class CustomerVerificationResponseDto
{
    public bool IsSuccess { get; set; }
    public CustomerVerificationSuccessResponseDto? SuccessResponse { get; set; }
    public CustomerVerificationErrorResponseDto? ErrorResponse { get; set; }
}

public class CustomerRejectionResponseDto
{
    public bool IsSuccess { get; set; }
    public CustomerRejectionSuccessResponseDto? SuccessResponse { get; set; }
    public CustomerRejectionErrorResponseDto? ErrorResponse { get; set; }
}