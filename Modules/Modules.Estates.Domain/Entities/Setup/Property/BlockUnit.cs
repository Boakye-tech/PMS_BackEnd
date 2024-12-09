namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockUnit : AuditableEntity
{
    [Key]
    [Required]
    public int UnitId { get; set; }


    [Required]
    [StringLength(2)]
    public string? Unit { get; set; }

    public BlockUnit(int unitId, string unit)
    {
        UnitId = unitId;
        Unit = unit;
    }

    public static BlockUnit Create(int unitId, string unit)
    {
        if (string.IsNullOrWhiteSpace(unit) || unitId < 0)
        {
            throw new ArgumentException("Invalid Block Unit Data.");
        }

        if (unitId <= -1)
            throw new ArgumentException("Block Unit Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(unit) || unit.Length > 2)
            throw new ArgumentException("Block Unit must not be null or exceed 2 characters.");


        return new BlockUnit(unitId, unit);
    }

    public static BlockUnit Update(int unitId, string unit)
    {
        if (string.IsNullOrWhiteSpace(unit) || unitId < 0)
        {
            throw new ArgumentException("Invalid Block Unit Data.");
        }

        if (unitId <= -1)
            throw new ArgumentException("Block Unit Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(unit) || unit.Length > 2)
            throw new ArgumentException("Block Unit must not be null or exceed 2 characters.");


        return new BlockUnit(unitId, unit);
    }

}

