namespace Modules.Estates.Application.DTO.Setup.Customer;

public record IdentificationTypeReadDto(int identificationTypeId, string identificationTypes);
public record IdentificationTypeCreateDto(int identificationTypeId, string identificationTypes, string createdBy);
public record IdentificationTypeUpdateDto(int identificationTypeId, string identificationTypes, string modifiedBy);
public record IdentificationTypeDeleteDto(int identificationTypeId);
