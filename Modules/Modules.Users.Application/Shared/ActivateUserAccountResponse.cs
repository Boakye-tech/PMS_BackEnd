// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

