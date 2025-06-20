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
	public record FeaturesReadDto(int FeaturesId, string Feature);
    public record FeaturesCreateDto(string Feature, string CreatedBy);
    public record FeaturesUpdateDto(int FeaturesId, string Feature, string ModifiedBy);
    public record FeaturesDeleteDto(int FeaturesId, string DeletedBy);



}

