namespace Modules.Estates.Application.DTO.Setup.Property;

public record FloorNumberingReadDto(int floorNumberId, string floorNumber);
public record FloorNumberingCreateDto(int floorNumberId, string floorNumber, string createdby);
public record FloorNumberingUpdateDto(int floorNumberId, string floorNumber, string modified);
public record FloorNumberingDeleteDto(int floorNumberId);
