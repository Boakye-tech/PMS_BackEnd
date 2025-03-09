namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface IGenderService
{
    Task<GenderReadDto> AddGenderAsync(GenderCreateDto values);
    Task<GenderReadDto> UpdateGenderAsync(GenderUpdateDto values);
    Task<IEnumerable<GenderReadDto>> GetGenderAsync();
    Task<GenderReadDto> GetGenderAsync(int value);
    Task<GenderReadDto> GetGenderAsync(string value);

    Task<string> DeleteGenderAsync(int value);
}

