namespace Modules.Estates.Application.DTO.Setup.Customer;

public record SocialMediaReadDto(int SocialMediaId, string SocialMediaPlatform);
public record SocialMediaCreateDto(int SocialMediaId, string SocialMediaPlatform, string CreatedBy);
public record SocialMediaUpdateDto(int SocialMediaId, string SocialMediaPlatform, string ModifiedBy);
public record SocialMediaDeleteDto(int SocialMediaId);
