// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/FloorNumbering.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:12 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class FloorNumbering : AuditableEntity
{
    [Key]
    [Required]
    public int FloorNumberId { get; private set; }

    [Required]
    [StringLength(25)]
    public string FloorNumber { get; private set; }

    public FloorNumbering(int floorNumberId, string floorNumber)
    {
        FloorNumberId = floorNumberId;
        FloorNumber = floorNumber;
    }

    public static FloorNumbering Create(int floorNumberId, string floorNumber)
    {
        Validate(floorNumberId, floorNumber);
        return new FloorNumbering(floorNumberId, floorNumber);
    }

    public void Update(int floorNumberId, string floorNumber)
    {
        Validate(floorNumberId, floorNumber);

        FloorNumberId = floorNumberId;
        FloorNumber = floorNumber;
    }

    private static void Validate(int floorNumberId, string floorNumber)
    {
        if (floorNumberId < 0)
            throw new ArgumentException("Floor Numbering Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(floorNumber) || floorNumber.Length > 25)
            throw new ArgumentException("Floor Numbering cannot be empty or exceed 25 characters.");
    }
}

