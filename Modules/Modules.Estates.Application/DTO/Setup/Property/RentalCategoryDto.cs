// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/RentalCategoryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 2:10 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record RentalCategoryReadDto(int RentalCategoryId, string RentalCategories);
    public record RentalCategoryCreateDto(string RentalCategories, string CreatedBy);
    public record RentalCategoryUpdateDto(int RentalCategoryId, string RentalCategories, string ModifiedBy);
    public record RentalCategoryDeleteDto(int RentalCategoryId, string DeletedBy);
}

