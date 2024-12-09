namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IApartmentTypeService
{
    Task<ApartmentTypeReadDto> AddApartmentTypeAsync(ApartmentTypeCreateDto values);
    Task<ApartmentTypeReadDto> UpdateApartmentTypeAsync(ApartmentTypeUpdateDto values);
    Task<IEnumerable<ApartmentTypeReadDto>> GetApartmentTypeAsync();
    Task<ApartmentTypeReadDto> GetApartmentTypeAsync(int value);
    Task<ApartmentTypeReadDto> GetApartmentTypeAsync(string value);
}

