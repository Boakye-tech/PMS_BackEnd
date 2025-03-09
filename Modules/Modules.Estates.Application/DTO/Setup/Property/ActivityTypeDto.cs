using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
    public record ActivityTypeReadDto(int ActivityId, int ActivityTypeId, string ActivityTypeName, string ActivityTypeDescription);
    public record ActivityTypeCreateDto(int ActivityId, int ActivityTypeId, string ActivityTypeName, string ActivityTypeDescription, string CreatedBy);
    public record ActivityTypeUpdateDto(int ActivityId, int ActivityTypeId, string ActivityTypeName, string ActivityTypeDescription, string ModifiedBy);
    public record ActivityTypeDeleteDto(int ActivityId);
}

