// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyHeight.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PropertyHeight : AuditableEntity
{
    [Key]
    [Required]
    public int PropertyHeightId { get; private set; }

    [Required]
    [StringLength(30)]
    public string PropertyHeights { get; private set; }

    public PropertyHeight(int propertyHeightId, string propertyHeights)
    {
        PropertyHeightId = propertyHeightId;
        PropertyHeights = propertyHeights;
    }

    public static PropertyHeight Create(int propertyHeightId, string propertyHeights)
    {
        Validate(propertyHeightId, propertyHeights);
        return new PropertyHeight(propertyHeightId, propertyHeights);
    }

    public void Update(int propertyHeightId, string propertyHeights)
    {
        Validate(propertyHeightId, propertyHeights);

        PropertyHeightId = propertyHeightId;
        PropertyHeights = propertyHeights;
    }

    private static void Validate(int propertyHeightId, string propertyHeights)
    {
        if (propertyHeightId < 0)
            throw new ArgumentException("Property Height Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(propertyHeights) || propertyHeights.Length > 30)
            throw new ArgumentException("Property Heights cannot be empty or exceed 30 characters.");
    }
}

