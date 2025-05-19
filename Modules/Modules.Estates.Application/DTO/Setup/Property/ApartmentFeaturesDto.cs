// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ApartmentFeaturesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/05/2025 4:22 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.DTO.Setup.Property
{
    public record ApartmentFeaturesReadDto(int ApartmentFeaturesId, string ApartmentCategory, string ApartmentType, string Feature, decimal FloorArea);

    public record ApartmentFeaturesCreateDto(ApartmentCategoryEnum ApartmentCategory, int ApartmentTypeId, string Feature, decimal FloorArea, string CreatedBy);
    public record ApartmentFeaturesUpdateDto(ApartmentCategoryEnum ApartmentCategory, int ApartmentTypeId, int ApartmentFeaturesId, string Feature, decimal FloorArea, string ModifiedBy);
    public record ApartmentFeaturesDeleteDto(int ApartmentFeaturesId, string DeletedBy);
}