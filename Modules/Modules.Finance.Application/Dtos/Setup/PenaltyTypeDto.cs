// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/PenaltyTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 3:06 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Dtos.Setup
{
    public record PenaltyTypeReadDto(int PenaltyTypeId, string Name, string Code, string Description, bool IsActive);
    public record PenaltyTypeCreateDto(string Name, string Code, string Description, bool IsActive, string CreatedBy);
    public record PenaltyTypeUpdateDto(int PenaltyTypeId, string Name, string Code, string Description, bool IsActive, string ModifiedBy);
    public record PenaltyTypeDeleteDto(int PenaltyTypeId);


    public record PenaltyTypeWithRulesReadDto(
    int PenaltyTypeId,
    string Name,
    string Code,
    string Description,
    bool IsActive,
    List<PenaltyRuleReadDto> PenaltyRules);
}

