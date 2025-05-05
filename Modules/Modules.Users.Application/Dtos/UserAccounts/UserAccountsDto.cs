// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.UserAccounts
{
    public record LoginResponseDto
    {
        public bool LoginStatus { get; set; }
        public LoginSucessResponseDto? successResponse { get; set; }
        public LoginErrorResponseDto? errorResponse { get; set; }
    }

    public record LoginSucessResponseDto() : LoginResponse;
  
    public record LoginErrorResponseDto() : BaseResponse;

    public record ChangePasswordRequestDto() : ChangePasswordRequest;

    public record ResetPasswordRequestDto() : PasswordResetRequest;
    

}

