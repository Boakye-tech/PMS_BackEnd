// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ControllerServices/IRentalsServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/05/2025 7:44 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.ControllerServices
{
	public interface IRentalsServices
	{
		// Rental Category methods
		Task<IEnumerable<RentalCategoryReadDto>> GetRentalCategoryAsync();
		Task<ReturnResponsesDto> CreateRentalCategoryAsync(RentalCategoryCreateDto values);
		Task<ReturnResponsesDto> UpdateRentalCategoryAsync(RentalCategoryUpdateDto values);
		Task<ReturnResponsesDto> DeleteRentalCategory(int rentalCategoryId);

		// Rental Type methods
		Task<IEnumerable<RentalTypeReadDto>> GetRentalTypeAsync(int rentalCategoryId);
		Task<ReturnResponsesDto> CreateRentalTypeAsync(RentalTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateRentalTypeAsync(RentalTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteRentalType(int rentalTypeId);


        // Rental Category and Rental Type methods
        Task<List<RentalCategoryAndRentalTypeReadDto>> GetRentalCategoryAndRentalTypeAsync();

        // Shop/Office Type methods
        Task<IEnumerable<ShopOfficeTypesReadDto>> GetShopOfficeTypesAsync();
		Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(int value);
		Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(string value);
		Task<ReturnResponsesDto> CreateShopOfficeTypesAsync(ShopOfficeTypesCreateDto values);
		Task<ReturnResponsesDto> UpdateShopOfficeTypesAsync(ShopOfficeTypesUpdateDto values);
		Task<ReturnResponsesDto> DeleteShopOfficeTypes(int shopOfficeTypesId);

		// House Type methods
		Task<IEnumerable<HouseTypesReadDto>> GetHouseTypesAsync();
		Task<ReturnResponsesDto> CreateHouseTypesAsync(HouseTypesCreateDto values);
		Task<ReturnResponsesDto> UpdateHouseTypesAsync(HouseTypesUpdateDto values);
		Task<ReturnResponsesDto> DeleteHouseTypes(int houseTypesId);

        // Types methods
        Task<List<AllTypesRentalCategoryDto>> GetAllTypesAsync();
        Task<ReturnResponsesDto> CreateTypesAsync(TypesCreateDto values);
        Task<ReturnResponsesDto> UpdateTypesAsync(TypesUpdateDto values);
        Task<ReturnResponsesDto> DeleteTypes(int typesId);
        


    }
}

