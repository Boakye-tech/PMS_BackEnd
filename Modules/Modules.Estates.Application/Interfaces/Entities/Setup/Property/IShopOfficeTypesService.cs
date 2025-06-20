// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IShopOfficeTypesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 3:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Application.DTO.Setup.Property;

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
    public interface IShopOfficeTypesService
    {
        Task<IEnumerable<ShopOfficeTypesReadDto>> GetShopOfficeTypesAsync();
        Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(int value);
        Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(string value);
        Task<ReturnResponsesDto> CreateShopOfficeTypesAsync(ShopOfficeTypesCreateDto values);
        Task<ReturnResponsesDto> UpdateShopOfficeTypesAsync(ShopOfficeTypesUpdateDto values);
        Task<ReturnResponsesDto> DeleteShopOfficeTypes(int shopOfficeTypesId);
    }
}

