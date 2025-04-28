// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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