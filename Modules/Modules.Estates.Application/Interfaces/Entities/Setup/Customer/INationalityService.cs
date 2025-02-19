namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface INationalityService
{
    Task<NationalityReadDto> AddNationalityAsync(NationalityCreateDto values);
    Task<NationalityReadDto> UpdateNationalityAsync(NationalityUpdateDto values);
    Task<IEnumerable<NationalityReadDto>> GetNationalityAsync();
    Task<NationalityReadDto> GetNationalityAsync(int value);
    Task<NationalityReadDto> GetNationalityAsync(string value);

    Task<string> DeleteNationalityAsync(int value);
}

