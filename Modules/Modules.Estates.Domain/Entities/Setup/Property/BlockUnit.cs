// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockUnit.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:05 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockUnit : AuditableEntity
{
    [Key]
    [Required]
    public int UnitId { get; private set; }

    [Required]
    [StringLength(2)]
    public string Unit { get; private set; }

    public BlockUnit(int unitId, string unit)
    {
        UnitId = unitId;
        Unit = unit;
    }

    public static BlockUnit Create(int unitId, string unit)
    {
        Validate(unitId, unit);
        return new BlockUnit(unitId, unit);
    }

    public void Update(int unitId, string unit)
    {
        Validate(unitId, unit);

        UnitId = unitId;
        Unit = unit;
    }

    private static void Validate(int unitId, string unit)
    {
        if (unitId < 0)
            throw new ArgumentException("Block Unit Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(unit) || unit.Length > 2)
            throw new ArgumentException("Block Unit cannot be empty or exceed 2 characters.");
    }
}

