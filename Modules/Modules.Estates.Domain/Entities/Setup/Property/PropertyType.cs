namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PropertyType : AuditableEntity
{
    [Key]
    public int PropertyTypeId { get; private set; }

    [Required]
    [MaxLength(50)]
    public string? PropertyTypes { get; private set; }

    public PropertyType(int propertyTypeId, string? propertyTypes)
    {
        PropertyTypeId = propertyTypeId;
        PropertyTypes = propertyTypes;
    }

    public static PropertyType Create(int propertyTypeId, string propertyTypes)
    {
        if (string.IsNullOrWhiteSpace(propertyTypes) || propertyTypeId < 0)
        {
            throw new ArgumentException("Invalid Property Type Data.");
        }

        if (propertyTypeId <= -1)
            throw new ArgumentException("Property Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(propertyTypes) || propertyTypes.Length > 50)
            throw new ArgumentException("Property Type must not be null or exceed 50 characters.");


        return new PropertyType(propertyTypeId, propertyTypes);
    }


    public static PropertyType Update(int propertyTypeId, string propertyTypes)
    {
        if (string.IsNullOrWhiteSpace(propertyTypes) || propertyTypeId < 0)
        {
            throw new ArgumentException("Invalid Property Type Data.");
        }

        if (propertyTypeId <= -1)
            throw new ArgumentException("Property Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(propertyTypes) || propertyTypes.Length > 50)
            throw new ArgumentException("Property Type must not be null or exceed 50 characters.");


        return new PropertyType(propertyTypeId, propertyTypes);
    }
}

