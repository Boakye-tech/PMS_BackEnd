using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record ActivityReadDto(int ActivityId, string ActivityName, string ActivityDescription);
    public record ActivityCreateDto(int ActivityId, string ActivityName, string ActivityDescription, string CreatedBy);
    public record ActivityUpdateDto(int ActivityId, string ActivityName, string ActivityDescription, string ModifiedBy);
    public record ActivityDeleteDto(int ActivityId);

}

