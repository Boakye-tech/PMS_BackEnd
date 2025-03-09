namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IFacilitiesService
{
    Task<FacilitiesReadDto> AddFacilitiesAsync(FacilitiesCreateDto values);
    Task<FacilitiesReadDto> UpdateFacilitiesAsync(FacilitiesUpdateDto values);
    Task<IEnumerable<FacilitiesReadDto>> GetFacilitiesAsync();
    Task<FacilitiesReadDto> GetFacilitiesAsync(int value);
    Task<FacilitiesReadDto> GetFacilitiesAsync(string value);
}

