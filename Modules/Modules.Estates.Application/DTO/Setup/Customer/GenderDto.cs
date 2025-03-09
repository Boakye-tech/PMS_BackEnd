namespace Modules.Estates.Application.DTO.Setup.Customer;

public record GenderReadDto(int genderId, string genderType);
public record GenderCreateDto(int genderId, string genderType, string createdBy);
public record GenderUpdateDto(int genderId, string genderType, string modifiedBy);
public record GenderDeleteDto(int genderId);
