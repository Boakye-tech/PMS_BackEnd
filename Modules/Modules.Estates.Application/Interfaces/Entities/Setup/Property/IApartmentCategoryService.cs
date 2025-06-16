// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IApartmentCategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/06/2025 5:38 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Application.DTO.Setup.Property;

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IApartmentCategoryService
{
	Task<ReturnResponsesDto> CreateApartmentCategoryAsync(ApartmentCategoryCreateDto values);
	Task<ReturnResponsesDto> UpdateApartmentCategoryAsync(ApartmentCategoryUpdateDto values);
	Task<IEnumerable<ApartmentCategoryReadDto>> GetApartmentCategoryAsync();

	Task<ReturnResponsesDto> DeleteApartmentCategory(int apartmentCategoryId);

	Task<List<ApartmentCategoryAndTypesReadDto>> GetApartmentCategoryAndTypesAsync();
}

