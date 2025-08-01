// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ApartmentCategoryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/06/2025 5:38 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Application.DTO.Setup.Property;

public record ApartmentCategoryReadDto(int ApartmentCategoryId, string ApartmentCategoryName);
public record ApartmentCategoryCreateDto(string? ApartmentCategoryName, string CreatedBy);
public record ApartmentCategoryUpdateDto(int ApartmentCategoryId, string? ApartmentCategoryName, string ModifiedBy);
public record ApartmentCategoryDeleteDto(int ApartmentCategoryId);


public record ApartmentTypesReadDto(int apartmentTypeId = 0, string apartmentType = "", List<ApartmentFeatureReadDto> apartmentfeatures = null!, float sellingPrice =0f, int currencyId = 0, string currencyInitial="", string currency="", int floorAreaId=0,
    decimal? floorArea=null!, string[]? images= null!);

public record ApartmentCategoriesReadDto(int ApartmentCategoryId, string ApartmentCategoryName, bool IsOpen);
public record ApartmentCategoryAndTypesReadDto(ApartmentCategoriesReadDto ApartmentCategories, IEnumerable<ApartmentTypesReadDto> ApartmentTypes);