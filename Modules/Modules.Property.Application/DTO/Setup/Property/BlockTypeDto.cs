namespace Modules.Estates.Application.DTO.Setup.Property;

public record BlockTypeReadDto(int blockTypeId, string blockType);
public record BlockTypeCreateDto(int blockTypeId, string blockType, string createdby);
public record BlockTypeUpdateDto(int blockTypeId, string blockType, string modifiedby);
public record BlockTypeDeleteDto(int blockTypeId);
