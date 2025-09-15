// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Dtos/Setups/ConsentTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Legal.Application.Dtos.Setups
{
    public record ConsentTypeRedDto(int consentTypeId, string consentType);
    public record ConsentTypeCreateDto(string consentType, string createdBy);
    public record ConsentTypeUpdateDto(int consentTypeId, string consentType, string modifiedBy);
    public record ConsentTypeDeleteDto(int consentTypeId);

}


