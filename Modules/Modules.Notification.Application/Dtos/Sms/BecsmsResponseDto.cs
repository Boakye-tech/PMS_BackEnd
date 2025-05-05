// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Application.Dtos.Sms
{
	public record BecsmsResponseDto
	{
        public bool success { get; set; }
        public int code { get; set; }
        public BecsmsResponseDataDto? data { get; set; }
        public string? message { get; set; }

    }
}

