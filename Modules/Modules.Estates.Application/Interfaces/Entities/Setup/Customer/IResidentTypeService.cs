namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface IResidentTypeService
{
    Task<ResidentTypeReadDto> AddResidentTypeAsync(ResidentTypeCreateDto values);
    Task<ResidentTypeReadDto> UpdateResidentTypeAsync(ResidentTypeUpdateDto values);
    Task<IEnumerable<ResidentTypeReadDto>> GetResidentTypeAsync();
    Task<ResidentTypeReadDto> GetResidentTypeAsync(int value);
    Task<ResidentTypeReadDto> GetResidentTypeAsync(string value);
}

