using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface ILocalityService
{
    Task<LocalityReadDto> AddLocalityAsync(LocalityCreateDto values);
    Task<LocalityReadDto> UpdateLocalityAsync(LocalityUpdateDto values);
    Task<IEnumerable<LocalityReadDto>> GetLocalityAsync();
    Task<LocalityReadDto> GetLocalityAsync(int value);
    Task<LocalityReadDto> GetLocalityAsync(string value);
}

