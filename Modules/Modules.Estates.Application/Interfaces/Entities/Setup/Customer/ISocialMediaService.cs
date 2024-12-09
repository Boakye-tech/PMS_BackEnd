namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface ISocialMediaService
{
    Task<SocialMediaReadDto> AddSocialMediaAsync(SocialMediaCreateDto values);
    Task<SocialMediaReadDto> UpdateSocialMediaAsync(SocialMediaUpdateDto values);
    Task<IEnumerable<SocialMediaReadDto>> GetSocialMediaAsync();
    Task<SocialMediaReadDto> GetSocialMediaAsync(int value);
    Task<SocialMediaReadDto> GetSocialMediaAsync(string value);
}

