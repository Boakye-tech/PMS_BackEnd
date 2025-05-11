// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
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
    [StringLength(50)]
    public string PropertyTypes { get; private set; }

    public PropertyType(int propertyTypeId, string propertyTypes)
    {
        PropertyTypeId = propertyTypeId;
        PropertyTypes = propertyTypes;
    }

    public static PropertyType Create(int propertyTypeId, string propertyTypes)
    {
        Validate(propertyTypeId, propertyTypes);
        return new PropertyType(propertyTypeId, propertyTypes);
    }

    public void Update(int propertyTypeId, string propertyTypes)
    {
        Validate(propertyTypeId, propertyTypes);

        PropertyTypeId = propertyTypeId;
        PropertyTypes = propertyTypes;
    }

    private static void Validate(int propertyTypeId, string propertyTypes)
    {
        if (propertyTypeId <= 0)
            throw new ArgumentException("Property Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(propertyTypes))
            throw new ArgumentException("Property Types cannot be empty or exceed 50 characters.");
    }
}

