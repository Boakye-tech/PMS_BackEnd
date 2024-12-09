namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IPropertyTypeService
{
    Task<PropertyTypeReadDto> AddPropertyTypeAsync(PropertyTypeCreateDto values);
    Task<PropertyTypeReadDto> UpdatePropertyTypeAsync(PropertyTypeUpdateDto values);
    Task<IEnumerable<PropertyTypeReadDto>> GetPropertyTypeAsync();
    Task<PropertyTypeReadDto> GetPropertyTypeAsync(int value);
    Task<PropertyTypeReadDto> GetPropertyTypeAsync(string value);
}

