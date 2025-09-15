// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Interfaces/Setups/ICaseTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:23 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Legal.Application.Dtos;
using Modules.Legal.Application.Dtos.Setups;

namespace Modules.Legal.Application.Interfaces.Setups
{
	public interface ICaseTypeService
	{
        Task<ReturnResponsesDto> CreateCaseTypeAsync(CaseTypeCreateDto values);
        Task<ReturnResponsesDto> UpdateCaseTypeAsync(CaseTypeUpdateDto values);
        Task<ReturnResponsesDto> DeleteCaseType(int caseTypeId);
        Task<List<CaseTypeReadDto>> GetCaseTypeAsync();
        Task<CaseTypeReadDto> GetCaseTypeAsync(int caseTypeId);

    }
}

