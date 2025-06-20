// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Facilities.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:07 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class FloorArea : AuditableEntity
{
    [Key]
    [Required]
    public int FloorAreaId { get; private set; }

    [Required]
    public decimal Area { get; private set; }

    public FloorArea(int floorAreaId, decimal area)
    {
        FloorAreaId = floorAreaId;
        Area = area;
    }

    public static FloorArea Create(int floorAreaId, decimal area)
    {
        Validate(floorAreaId, area);
        return new FloorArea(floorAreaId, area);
    }

    public void Update(int floorAreaId, decimal area)
    {
        Validate(floorAreaId, area);

        FloorAreaId = floorAreaId;
        Area = area;
    }

    private static void Validate(int floorAreaId, decimal Area)
    {
        if (floorAreaId < 0)
            throw new ArgumentException("Floor Area Id must be greater than zero.");

        if (Area < 0)
            throw new ArgumentException("Floor Area must be greater than zero.");


    }
}

