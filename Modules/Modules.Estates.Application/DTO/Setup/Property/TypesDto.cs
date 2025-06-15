// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/TypesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 9:26 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
    public record TypesReadDto(int TypeId, string Code, string TypeName, int RentalCategoryId, string RentalCategory, int RentalTypeId, string RentalType, string[] Features, string Notes);
    public record TypesCreateDto(int RentalCategoryId, int RentalTypeId, string Code, string TypeName, string[] Features, string Notes, string CreatedBy);
    public record TypesUpdateDto(int RentalCategoryId, int RentalTypeId, int TypeId, string Code, string TypeName, string[] Features, string Notes, string ModifiedBy);
    public record TypesDeleteDto(int TypeId, string DeletedBy);


    public record AllTypesReadDto(int TypeId, string Code, string TypeName, string[] Features, string Notes);
    public record AllRentalTypesReadDto(int RentalTypeId, string RentalType, List<AllTypesReadDto> TypesPerRentalType);
    public record AllTypesRentalCategoryDto(int RentalCategoryId, string RentalCategory, List<AllRentalTypesReadDto> RentalTypesPerCategory);

}

