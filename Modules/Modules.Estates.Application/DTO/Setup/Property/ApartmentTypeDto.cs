namespace Modules.Estates.Application.DTO.Setup.Property;

public record ApartmentTypeReadDto(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea);
public record ApartmentTypeCreateDto(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea, string createdBy);
public record ApartmentTypeUpdateDto(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea, string modifiedBy);
public record ApartmentTypeDeleteDto(int apartmentTypeId);
