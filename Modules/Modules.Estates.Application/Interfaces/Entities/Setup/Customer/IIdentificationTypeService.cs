namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface IIdentificationTypeService
{
    Task<IdentificationTypeReadDto> AddIdentificationTypeAsync(IdentificationTypeCreateDto values);
    Task<IdentificationTypeReadDto> UpdateIdentificationTypeAsync(IdentificationTypeUpdateDto values);
    Task<IEnumerable<IdentificationTypeReadDto>> GetIdentificationTypeAsync();
    Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(int value);
    Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(string value);

    Task<string> DeleteIdentificationTypeAsync(int value);
}

