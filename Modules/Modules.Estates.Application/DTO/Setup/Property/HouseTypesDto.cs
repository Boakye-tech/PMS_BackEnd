// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/HouseTypesDto.cs
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
    public record HouseTypesReadDto(int HouseTypeId, string Code, string TypeName, int RentalCategoryId, string RentalCategory, int RentalTypeId, string RentalType, string[] Features, string Notes);
    public record HouseTypesCreateDto(string Code, string TypeName, int RentalCategoryId, int RentalTypeId, string[] Features, string Notes, string CreatedBy);
    public record HouseTypesUpdateDto(int HouseTypeId, string Code, string TypeName, int RentalCategoryId, int RentalTypeId, string[] Features, string Notes, string ModifiedBy);
    public record HouseTypesDeleteDto(int HouseTypeId, string DeletedBy);
}

