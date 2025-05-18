// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IShopOfficeTypeAndDescriptionService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 8:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface IShopOfficeTypeAndDescriptionService
	{
        Task<ReturnResponsesDto> CreateShopOfficeTypeAndDescriptionAsync(ShopOfficeTypeAndDescriptionCreateDto values);
        Task<ReturnResponsesDto> UpdateShopOfficeTypeAndDescriptionAsync(ShopOfficeTypeAndDescriptionUpdateDto values);
        Task<ReturnResponsesDto> DeleteShopOfficeTypeAndDescription(int ShopOfficeTypeAndDescriptionId);
        Task<IEnumerable<ShopOfficeTypeAndDescriptionReadDto>> GetShopOfficeTypeAndDescriptionAsync();
    }
}

