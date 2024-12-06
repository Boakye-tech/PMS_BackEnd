namespace Modules.Estates.Application.DTO.Setup.Property;

public record BlockSideReadDto(int sideId, string side);
public record BlockSideCreateDto(int sideId, string side, string createdby);
public record BlockSideUpdateDto(int sideId, string side, string modifiedby);
public record BlockSideDeleteDto(int sideId);
