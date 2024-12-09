namespace Modules.Estates.Application.DTO.Setup.Property;

public record PropertyHeightReadDto(int propertyHeightId, string propertyHeights);
public record PropertyHeightCreateDto(int propertyHeightId, string propertyHeights, string createdBy);
public record PropertyHeightUpdateDto(int propertyHeightId, string propertyHeights, string modifiedBy);
public record PropertyHeightDeleteDto(int propertyHeightId);
