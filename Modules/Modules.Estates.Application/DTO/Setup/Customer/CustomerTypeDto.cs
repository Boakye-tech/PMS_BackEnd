namespace Modules.Estates.Application.DTO.Setup.Customer;

public record CustomerTypeReadDto(int customerTypeId, string customerTypes);
public record CustomerTypeCreateDto(int customerTypeId, string customerTypes, string createdBy);
public record CustomerTypeUpdateDto(int customerTypeId, string customerTypes, string modifiedBy);
public record CustomerTypeDeleteDto(int customerTypeId);
