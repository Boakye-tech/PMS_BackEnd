// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/BecsmsResponseDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 6:08 PM
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

