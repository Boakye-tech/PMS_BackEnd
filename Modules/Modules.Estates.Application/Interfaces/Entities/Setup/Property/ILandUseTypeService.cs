using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface ILandUseTypeService
{
    Task<LandUseTypeReadDto> AddLandUseTypeAsync(LandUseTypeCreateDto values);
    Task<LandUseTypeReadDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values);
    Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync();
    Task<LandUseTypeReadDto> GetLandUseTypeAsync(int value);
    Task<LandUseTypeReadDto> GetLandUseTypeAsync(string value);
}

