namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class SocialMedia : AuditableEntity
{
    [Key]
    [Required]
    public int SocialMediaId { get; set; }

    [Required]
    [StringLength(15)]
    public string SocialMediaPlatform { get; set; }

    public SocialMedia(int socialMediaId, string socialMediaPlatform)
    {
        SocialMediaId = socialMediaId;
        SocialMediaPlatform = socialMediaPlatform;
    }

    public static SocialMedia Create(int socialmediaId, string socialmediaPlatform)
    {
        if (string.IsNullOrWhiteSpace(socialmediaPlatform) || socialmediaId < 0)
        {
            throw new ArgumentException("Invalid Social Media Data.");
        }

        if (socialmediaId <= -1)
            throw new ArgumentException("Social Media Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(socialmediaPlatform) || socialmediaPlatform.Length > 20)
            throw new ArgumentException("Social Media must not be null or exceed 20 characters.");


        return new SocialMedia(socialmediaId, socialmediaPlatform);
    }

    public static SocialMedia Update(int socialmediaId, string socialmediaPlatform)
    {
        if (string.IsNullOrWhiteSpace(socialmediaPlatform) || socialmediaId < 0)
        {
            throw new ArgumentException("Invalid Social Media Data.");
        }

        if (socialmediaId <= -1)
            throw new ArgumentException("Social Media Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(socialmediaPlatform) || socialmediaPlatform.Length > 20)
            throw new ArgumentException("Social Media must not be null or exceed 20 characters.");


        return new SocialMedia(socialmediaId, socialmediaPlatform);
    }

}

