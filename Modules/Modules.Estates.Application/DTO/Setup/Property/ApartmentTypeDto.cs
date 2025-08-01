// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ApartmentTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.DTO.Setup.Property;

public record ApartmentTypeReadDto(string apartmentCategory="", int apartmentTypeId=0, string apartmentType="", List<ApartmentFeatureReadDto> features=null!, float sellingPrice=0f,int currencyId=0, int floorAreaId=0, string[]? images=null!);

public record ApartmentTypeCreateDto(int apartmentCategoryId, string apartmentType, int[]? features, float sellingPrice, int currencyId, int floorAreaId, string[]? images, string createdBy);

public record ApartmentTypeUpdateDto(int apartmentCategoryId, int apartmentTypeId, string apartmentType, int[]? features, float sellingPrice, int currencyId, int floorAreaId, string[]? images, string modifiedBy);

public record ApartmentTypeDeleteDto(int apartmentTypeId);



public record ApartmentTypesDto(int apartmentTypeId, string apartmentType);


