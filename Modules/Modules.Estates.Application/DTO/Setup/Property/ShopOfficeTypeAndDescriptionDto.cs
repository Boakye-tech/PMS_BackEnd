// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ShopOfficeTypeAndDescriptionDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 8:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record ShopOfficeTypeAndDescriptionReadDto(ShopTypeCategoryEnum shopTypeCategory,int ShopOfficeTypeId, string TypeName, string Description);
    public record ShopOfficeTypeAndDescriptionCreateDto(ShopTypeCategoryEnum shopTypeCategory, string TypeName, string Description, string CreatedBy);
    public record ShopOfficeTypeAndDescriptionUpdateDto(ShopTypeCategoryEnum shopTypeCategory, int ShopOfficeTypeId, string TypeName, string Description, string ModifiedBy);
    public record ShopOfficeTypeAndDescriptionDeleteDto(int ShopOfficeTypeId, string DeletedBy);

}

