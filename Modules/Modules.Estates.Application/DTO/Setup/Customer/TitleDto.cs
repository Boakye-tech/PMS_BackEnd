namespace Modules.Estates.Application.DTO.Setup.Customer;

public record TitleReadDto(int titleId, string titles);
public record TitleCreateDto(int titleId, string titles, string createdby);
public record TitleUpdateDto(int titleId, string titles, string modifiedby);
public record TitleDeleteDto(int titleId);
