namespace Modules.Estates.Application.DTO.Setup.Property;

public record FacilitiesReadDto(int facilityId, string facility);
public record FacilitiesCreateDto(int facilityId, string facility, string createdBy);
public record FacilitiesUpdateDto(int facilityId, string facility, string modifiedBy);
public record FacilitiesDeleteDto(int facilityId);
