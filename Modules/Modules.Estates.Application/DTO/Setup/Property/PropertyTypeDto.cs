namespace Modules.Estates.Application.DTO.Setup.Property;

public record PropertyTypeReadDto(int PropertyTypeId, string PropertyTypes);
public record PropertyTypeCreateDto(int PropertyTypeId, string PropertyTypes, string CreatedBy);
public record PropertyTypeUpdateDto(int PropertyTypeId, string PropertyTypes, string ModifiedBy);
public record PropertyTypeDeleteDto(int PropertyTypeId);
