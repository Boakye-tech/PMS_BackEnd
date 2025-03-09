namespace Modules.Estates.Application.DTO.Setup.Property;

public record BlockNumberReadDto(int blockNumberId, string blockNumbers);
public record BlockNumberCreateDto(int blockNumberId, string blockNumbers, string createdby);
public record BlockNumberUpdateDto(int blockNumberId, string blockNumbers, string modifiedby);
public record BlockNumberDeleteDto(int blockNumberId);
