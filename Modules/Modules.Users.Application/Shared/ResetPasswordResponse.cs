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

