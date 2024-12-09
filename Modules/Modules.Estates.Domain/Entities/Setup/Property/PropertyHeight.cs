namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PropertyHeight : AuditableEntity
{

    [Key]
    public int PropertyHeightId { get; private set; }

    [Required]
    [MaxLength(30)]
    public string? PropertyHeights { get; private set; }


    public PropertyHeight(int propertyHeightId, string propertyHeights)
	{
        PropertyHeightId = propertyHeightId;
        PropertyHeights = propertyHeights;
    }


    public static PropertyHeight Create(int propertyHeightId, string propertyHeights)
    {
        if (string.IsNullOrWhiteSpace(propertyHeights) || propertyHeightId < 0)
        {
            throw new ArgumentException("Invalid Property Height Data.");
        }

        if (propertyHeightId <= -1)
            throw new ArgumentException("Property Height Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(propertyHeights) || propertyHeights.Length > 50)
            throw new ArgumentException("Property Type must not be null or exceed 50 characters.");


        return new PropertyHeight(propertyHeightId, propertyHeights);
    }

    public static PropertyHeight Update(int propertyHeightId, string propertyHeights)
    {
        if (string.IsNullOrWhiteSpace(propertyHeights) || propertyHeightId < 0)
        {
            throw new ArgumentException("Invalid Property Height Data.");
        }

        if (propertyHeightId <= -1)
            throw new ArgumentException("Property Height Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(propertyHeights) || propertyHeights.Length > 50)
            throw new ArgumentException("Property Type must not be null or exceed 50 characters.");


        return new PropertyHeight(propertyHeightId, propertyHeights);
    }

}

