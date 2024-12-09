namespace Modules.Estates.Application.DTO.Setup.Property;

public record LandUseReadDto(int LandUseId, string LandUseInitial, string LandUseName);
public record LandUseCreateDto(int LandUseId, string? LandUseInitial, string? LandUseName, string CreatedBy);
public record LandUseUpdateDto(int LandUseId, string? LandUseInitial, string? LandUseName, string ModifiedBy);
public record LandUseDeleteDto(int LandUseId);
