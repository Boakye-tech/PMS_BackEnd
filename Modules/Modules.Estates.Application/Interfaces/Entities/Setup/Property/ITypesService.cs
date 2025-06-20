// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ITypesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 9:28 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface ITypesService
	{
        Task<ReturnResponsesDto> CreateTypesAsync(TypesCreateDto values);
        Task<ReturnResponsesDto> UpdateTypesAsync(TypesUpdateDto values);
        Task<ReturnResponsesDto> DeleteTypes(int typesId);
        Task<List<AllTypesRentalCategoryDto>> GetAllTypesAsync();

    }
}

