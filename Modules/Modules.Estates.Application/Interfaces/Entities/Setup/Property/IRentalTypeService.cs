// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IRentalTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 2:56 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface IRentalTypeService
	{
		Task<ReturnResponsesDto> CreateRentalTypeAsync(RentalTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateRentalTypeAsync(RentalTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteRentalType(int rentalTypeId);
		Task<IEnumerable<RentalTypeReadDto>> GetRentalTypeAsync(int rentalCategoryId);
	}
}

