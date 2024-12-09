namespace Modules.Estates.Application.DTO.Setup.Customer;

public record NationalityReadDto(int nationalityId, string nationalities);
public record NationalityCreateDto(int nationalityId, string nationalities, string createdby);
public record NationalityUpdateDto(int nationalityId, string nationalities, string modifiedby);
public record NationalityDeleteDto(int nationalityId);
