// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Dtos/Setups/CaseTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:18 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Legal.Application.Dtos.Setups
{
	public record CaseTypeReadDto(int caseTypeId, string caseType);
    public record CaseTypeCreateDto(string caseType, string createdBy);
    public record CaseTypeUpdateDto(int caseTypeId, string caseType, string modifiedBy);
    public record CaseTypeDeleteDto(int caseTypeId);

}

