namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface ILandUseService
{
	Task<LandUseReadDto> AddLandUseAsync(LandUseCreateDto values);
    Task<LandUseReadDto> UpdateLandUseAsync(LandUseUpdateDto values);
    Task<IEnumerable<LandUseReadDto>> GetLandUseAsync();
    Task<LandUseReadDto> GetLandUseAsync(int value);
    Task<LandUseReadDto> GetLandUseAsync(string value);
}

