namespace Modules.Estates.Application.DTO.Setup.Property;

public record BlockUnitReadDto(int unitId, string unit);
public record BlockUnitCreateDto(int unitId, string unit, string createdby);
public record BlockUnitUpdateDto(int unitId, string unit, string modifiedby);
public record BlockUnitDeleteDto(int unitId);


