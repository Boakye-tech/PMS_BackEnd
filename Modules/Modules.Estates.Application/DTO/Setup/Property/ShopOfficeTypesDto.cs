// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ShopOfficesTypesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 8:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record ShopOfficeTypesReadDto(int ShopOfficeTypeId, string Code, string TypeName, int RentalCategoryId, string RentalCategory, int RentalTypeId, string RentalType, string[] Features, string Notes);
    public record ShopOfficeTypesCreateDto(string Code, string TypeName, int RentalCategoryId, int RentalTypeId, string[] Features, string Notes, string CreatedBy);
    public record ShopOfficeTypesUpdateDto(int ShopOfficeTypeId, string Code, string TypeName, int RentalCategoryId, int RentalTypeId, string[] Features, string Notes, string ModifiedBy);
    public record ShopOfficeTypesDeleteDto(int ShopOfficeTypeId, string DeletedBy);
}

