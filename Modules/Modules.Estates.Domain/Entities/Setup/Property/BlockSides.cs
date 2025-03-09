namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockSides : AuditableEntity
{
    [Key]
    [Required]
    public int SideId { get; set; }


    [Required]
    [StringLength(10)]
    public string? Side { get; set; }

    public BlockSides(int sideId, string side)
    {
        SideId = sideId;
        Side = side;
    }

    public static BlockSides Create(int sideId, string side)
    {
        if (string.IsNullOrWhiteSpace(side) || sideId < 0)
        {
            throw new ArgumentException("Invalid Block Side Data.");
        }

        if (sideId <= -1)
            throw new ArgumentException("Block Side Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(side) || side.Length > 10)
            throw new ArgumentException("Block Side must not be null or exceed 10 characters.");


        return new BlockSides(sideId, side);
    }

    public static BlockSides Update(int sideId, string side)
    {
        if (string.IsNullOrWhiteSpace(side) || sideId < 0)
        {
            throw new ArgumentException("Invalid Block Side Data.");
        }

        if (sideId <= -1)
            throw new ArgumentException("Block Side Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(side) || side.Length > 10)
            throw new ArgumentException("Block Side must not be null or exceed 10 characters.");


        return new BlockSides(sideId, side);
    }

}

