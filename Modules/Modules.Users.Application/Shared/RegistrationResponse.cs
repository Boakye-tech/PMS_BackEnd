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

	public record RegistrationSuccessResponse : BaseResponse
	{
        public required string UserId { get; set; }

        public required string UserEmailAddress { get; set; }
    }

    public record RegistrationErrorResponse : BaseResponse
    {
    }

    public record RegistrationResponse
    {
        public bool IsSuccess { get; set; }
        public RegistrationSuccessResponse? SuccessResponse { get; set; }
        public RegistrationErrorResponse? ErrorResponse { get; set; }
    }

}

