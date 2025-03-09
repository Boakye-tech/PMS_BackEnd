namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IPropertyHeightService
{
    Task<PropertyHeightReadDto> AddPropertyHeightAsync(PropertyHeightCreateDto values);
    Task<PropertyHeightReadDto> UpdatePropertyHeightAsync(PropertyHeightUpdateDto values);
    Task<IEnumerable<PropertyHeightReadDto>> GetPropertyHeightAsync();
    Task<PropertyHeightReadDto> GetPropertyHeightAsync(int value);
    Task<PropertyHeightReadDto> GetPropertyHeightAsync(string value);
}

