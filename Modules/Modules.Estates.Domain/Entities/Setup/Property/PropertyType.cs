// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/07/2025 5:11 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PropertyType : AuditableEntity
{
    [Key]
    [Required]
    public int PropertyTypeId { get; private set; }

    [Required]
    [StringLength(5)]
    public string? PropertyTypeInitial { get; private set; }

    [Required]
    [StringLength(30)]
    public string? PropertyTypeName { get; private set; }

    // Navigation property example (uncomment if needed)
    // public virtual ICollection<PropertyMaster> Properties { get; private set; }

    public PropertyType(int propertyTypeId, string? propertyTypeInitial, string? propertyTypeName)
    {
        PropertyTypeId = propertyTypeId;
        PropertyTypeInitial = propertyTypeInitial;
        PropertyTypeName = propertyTypeName;
        // Properties = new List<PropertyMaster>();
    }

    public static PropertyType Create(int propertyTypeId, string propertyTypeInitial, string propertyTypeName)
    {
        Validate(propertyTypeId, propertyTypeInitial, propertyTypeName);
        return new PropertyType(propertyTypeId, propertyTypeInitial, propertyTypeName);
    }

    public void Update(int propertyTypeId, string propertyTypeInitial, string propertyTypeName)
    {
        Validate(propertyTypeId, propertyTypeInitial, propertyTypeName);
        PropertyTypeInitial = propertyTypeInitial;
        PropertyTypeName = propertyTypeName;
    }

    private static void Validate(int propertyTypeId, string propertyTypeInitial, string propertyTypeName)
    {
        if (propertyTypeId < 0)
            throw new ArgumentException("Property Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(propertyTypeInitial) || propertyTypeInitial.Length > 5)
            throw new ArgumentException("Property Type Initial cannot be empty or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(propertyTypeName) || propertyTypeName.Length > 30)
            throw new ArgumentException("Property Type Name cannot be empty or exceed 30 characters.");
    }
}

