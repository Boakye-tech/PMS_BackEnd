// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/ControllerServices/RentalsServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 3:48 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



using Modules.Estates.Application.Interfaces.Entities.Setup.Property;

namespace Modules.Estates.Application.ControllerServices;

public class RentalsServices : IRentalsServices
{
    public IRentalCategoryService RentalCategoryService { get; }
    public IRentalTypeService RentalTypeService { get; }
    public IShopOfficeTypesService ShopOfficeTypesService { get; }
    public IHouseTypesService HouseTypesService { get; }

    public ITypesService AllTypesService { get; }

    public RentalsServices(IRentalCategoryService rentalCategoryService, IRentalTypeService rentalTypeService,IShopOfficeTypesService shopOfficeTypesService, IHouseTypesService houseTypesService, ITypesService allTypesService) //IRentalCategoryAndRentalTypeService rentalCategoryAndRentalTypeService,
    {
        RentalCategoryService = rentalCategoryService;
        RentalTypeService = rentalTypeService;
        ShopOfficeTypesService = shopOfficeTypesService;
        HouseTypesService = houseTypesService;
        AllTypesService = allTypesService;
    }

    // Rental Category methods
    public async Task<IEnumerable<RentalCategoryReadDto>> GetRentalCategoryAsync() =>
        await RentalCategoryService.GetRentalCategoryAsync();

    public async Task<ReturnResponsesDto> CreateRentalCategoryAsync(RentalCategoryCreateDto values) =>
        await RentalCategoryService.CreateRentalCategoryAsync(values);

    public async Task<ReturnResponsesDto> UpdateRentalCategoryAsync(RentalCategoryUpdateDto values) =>
        await RentalCategoryService.UpdateRentalCategoryAsync(values);

    public async Task<ReturnResponsesDto> DeleteRentalCategory(int rentalCategoryId) =>
        await RentalCategoryService.DeleteRentalCategory(rentalCategoryId);

    // Rental Category and Rental Type methods
    public async Task<List<RentalCategoryAndRentalTypeReadDto>> GetRentalCategoryAndRentalTypeAsync() =>
        await RentalCategoryService.GeRentalCategoryAndRentalTypeAsync();

    // Rental Type methods
    public async Task<IEnumerable<RentalTypeReadDto>> GetRentalTypeAsync(int rentalCategoryId) =>
        await RentalTypeService.GetRentalTypeAsync(rentalCategoryId);
    public async Task<ReturnResponsesDto> CreateRentalTypeAsync(RentalTypeCreateDto values) =>
        await RentalTypeService.CreateRentalTypeAsync(values);
    public async Task<ReturnResponsesDto> UpdateRentalTypeAsync(RentalTypeUpdateDto values) =>
        await RentalTypeService.UpdateRentalTypeAsync(values);
    public async Task<ReturnResponsesDto> DeleteRentalType(int rentalTypeId) =>
        await RentalTypeService.DeleteRentalType(rentalTypeId);

    // Shop/Office Type methods
    public async Task<IEnumerable<ShopOfficeTypesReadDto>> GetShopOfficeTypesAsync() =>
        await ShopOfficeTypesService.GetShopOfficeTypesAsync();

    public async Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(int value) =>
        await ShopOfficeTypesService.GetShopOfficeTypesAsync(value);

    public async Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(string value) =>
        await ShopOfficeTypesService.GetShopOfficeTypesAsync(value);

    public async Task<ReturnResponsesDto> CreateShopOfficeTypesAsync(ShopOfficeTypesCreateDto values) =>
        await ShopOfficeTypesService.CreateShopOfficeTypesAsync(values);

    public async Task<ReturnResponsesDto> UpdateShopOfficeTypesAsync(ShopOfficeTypesUpdateDto values) =>
        await ShopOfficeTypesService.UpdateShopOfficeTypesAsync(values);

    public async Task<ReturnResponsesDto> DeleteShopOfficeTypes(int shopOfficeTypesId) =>
        await ShopOfficeTypesService.DeleteShopOfficeTypes(shopOfficeTypesId);

    // House Type methods
    public async Task<IEnumerable<HouseTypesReadDto>> GetHouseTypesAsync() =>
        await HouseTypesService.GetHouseTypesAsync();

    public async Task<ReturnResponsesDto> CreateHouseTypesAsync(HouseTypesCreateDto values) =>
        await HouseTypesService.CreateHouseTypesAsync(values);

    public async Task<ReturnResponsesDto> UpdateHouseTypesAsync(HouseTypesUpdateDto values) =>
        await HouseTypesService.UpdateHouseTypesAsync(values);

    public async Task<ReturnResponsesDto> DeleteHouseTypes(int houseTypesId) =>
        await HouseTypesService.DeleteHouseTypes(houseTypesId);



    //All types methods
    public async Task<List<AllTypesRentalCategoryDto>> GetAllTypesAsync() =>
        await AllTypesService.GetAllTypesAsync();

    public async Task<ReturnResponsesDto> CreateTypesAsync(TypesCreateDto values) =>
        await AllTypesService.CreateTypesAsync(values);

    public async Task<ReturnResponsesDto> UpdateTypesAsync(TypesUpdateDto values) =>
        await AllTypesService.UpdateTypesAsync(values);

    public async Task<ReturnResponsesDto> DeleteTypes(int typesId) =>
        await AllTypesService.DeleteTypes(typesId);

}