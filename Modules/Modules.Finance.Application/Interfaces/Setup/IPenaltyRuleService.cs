// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IPenaltyRuleService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 3:13 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IPenaltyRuleService
    {
        Task<IEnumerable<PenaltyRuleReadDto>> GetPenaltyRulesAsync();
        Task<PenaltyRuleReadDto> GetPenaltyRuleAsync(int penaltyRuleId);
        Task<IEnumerable<PenaltyRuleReadDto>> GetActivePenaltyRulesAsync();
        Task<IEnumerable<PenaltyRuleReadDto>> GetPenaltyRulesByTypeAsync(int penaltyTypeId);
        Task<PenaltyRuleReadDto> GetCurrentPenaltyRuleAsync(int penaltyTypeId);
        Task<ReturnResponsesDto> CreatePenaltyRuleAsync(PenaltyRuleCreateDto values);
        Task<ReturnResponsesDto> UpdatePenaltyRuleAsync(PenaltyRuleUpdateDto values);
        Task<ReturnResponsesDto> DeletePenaltyRuleAsync(int penaltyRuleId);
        Task<decimal> CalculatePenaltyAsync(int penaltyRuleId, decimal principalAmount, int daysLate);
    }
}

