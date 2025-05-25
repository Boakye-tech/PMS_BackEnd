using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
    public record ActivityTypeReadDto(int ActivityId, int ActivityTypeId, string ActivityTypeName, string ActivityTypeDescription);
    public record ActivityTypeCreateDto(int ActivityId, string ActivityTypeName, string ActivityTypeDescription, string CreatedBy);
    public record ActivityTypeUpdateDto(int ActivityId, int ActivityTypeId, string ActivityTypeName, string ActivityTypeDescription, string ModifiedBy);
    public record ActivityTypeDeleteDto(int ActivityId);



    public record ActivityReadsDto(int ActivityId, string ActivityName, string ActivityDescription,bool IsOpen);
    public record ActivityAndActivityTypeReadDto(ActivityReadsDto Activity, List<ActivityTypeReadDto> ActivityTypes);

}

