namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface ITitleService
{
    Task<TitleReadDto> AddTitleAsync(TitleCreateDto values);
    Task<TitleReadDto> UpdateTitleAsync(TitleUpdateDto values);
    Task<IEnumerable<TitleReadDto>> GetTitleAsync();
    Task<TitleReadDto> GetTitleAsync(int value);
    Task<TitleReadDto> GetTitleAsync(string value);
}

