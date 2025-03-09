namespace Modules.Estates.Application.DTO.Setup.Customer;

public record ResidentTypeReadDto(int residentTypeId, string residentTypes);
public record ResidentTypeCreateDto(int residentTypeId, string residentTypes,string createdBy);
public record ResidentTypeUpdateDto(int residentTypeId, string residentTypes,string modifiedBy);
public record ResidentTypeDeleteDto(int residentTypeId);
