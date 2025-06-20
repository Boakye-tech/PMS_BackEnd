// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IRentalCategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 2:57 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface IRentalCategoryService
	{
		Task<ReturnResponsesDto> CreateRentalCategoryAsync(RentalCategoryCreateDto values);
		Task<ReturnResponsesDto> UpdateRentalCategoryAsync(RentalCategoryUpdateDto values);
		Task<ReturnResponsesDto> DeleteRentalCategory(int rentalCategoryId);
		Task<IEnumerable<RentalCategoryReadDto>> GetRentalCategoryAsync();

        Task<List<RentalCategoryAndRentalTypeReadDto>> GeRentalCategoryAndRentalTypeAsync();
    }
}

