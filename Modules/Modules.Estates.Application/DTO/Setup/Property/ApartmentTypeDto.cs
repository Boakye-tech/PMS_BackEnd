// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record ApartmentTypeReadDto(string apartmentCategory, int apartmentTypeId, string apartmentType, float sellingPrice,int currencyId, string currencyInitial, string currency, double floorArea);
public record ApartmentTypeCreateDto(ApartmentCategoryEnum apartmentCategory, string apartmentType, float sellingPrice, int currencyId, double floorArea, string createdBy);
public record ApartmentTypeUpdateDto(ApartmentCategoryEnum apartmentCategory,int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea, string modifiedBy);
public record ApartmentTypeDeleteDto(int apartmentTypeId);



