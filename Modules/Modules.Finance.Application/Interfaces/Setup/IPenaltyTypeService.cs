// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IPenaltyTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 3:12 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IPenaltyTypeService
    {
        Task<IEnumerable<PenaltyTypeReadDto>> GetPenaltyTypesAsync();
        Task<PenaltyTypeReadDto> GetPenaltyTypeAsync(int penaltyTypeId);
        Task<IEnumerable<PenaltyTypeReadDto>> GetActivePenaltyTypesAsync();
        Task<ReturnResponsesDto> CreatePenaltyTypeAsync(PenaltyTypeCreateDto values);
        Task<ReturnResponsesDto> UpdatePenaltyTypeAsync(PenaltyTypeUpdateDto values);
        Task<ReturnResponsesDto> DeletePenaltyTypeAsync(int penaltyTypeId);
        Task<ReturnResponsesDto> TogglePenaltyTypeStatusAsync(int penaltyTypeId, string modifiedBy);

        Task<IEnumerable<PenaltyTypeWithRulesReadDto>> GetPenaltyTypesWithRulesAsync();
        Task<PenaltyTypeWithRulesReadDto> GetPenaltyTypeWithRulesAsync(int penaltyTypeId);
    }
}

