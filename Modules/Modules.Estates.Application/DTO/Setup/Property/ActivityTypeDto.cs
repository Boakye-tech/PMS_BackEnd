// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ActivityTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property
{
    public record ActivityTypeReadDto(int ActivityId, int ActivityTypeId, string ActivityTypeName, string ActivityTypeDescription);
    public record ActivityTypeCreateDto(int ActivityId, string ActivityTypeName, string ActivityTypeDescription, string CreatedBy);
    public record ActivityTypeUpdateDto(int ActivityId, int ActivityTypeId, string ActivityTypeName, string ActivityTypeDescription, string ModifiedBy);
    public record ActivityTypeDeleteDto(int ActivityId);



    public record ActivityReadsDto(int ActivityId, string ActivityName, string ActivityDescription,bool IsOpen);
    public record ActivityAndActivityTypeReadDto(ActivityReadsDto Activity, List<ActivityTypeReadDto> ActivityTypes);

}

