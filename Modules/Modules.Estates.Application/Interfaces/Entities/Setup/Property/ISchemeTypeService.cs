// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ISchemeTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 12:24 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface ISchemeTypeService
	{
        Task<ReturnResponsesDto> CreateSchemeTypeAsync(SchemeTypeCreateDto values);
        Task<ReturnResponsesDto> UpdateSchemeTypeAsync(SchemeTypeUpdateDto values);
        Task<ReturnResponsesDto> DeleteSchemeType(int SchemeTypeId);
        Task<IEnumerable<SchemeTypeReadDto>> GetSchemeTypeAsync();

    }
}

