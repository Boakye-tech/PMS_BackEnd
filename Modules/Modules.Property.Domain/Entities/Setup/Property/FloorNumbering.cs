namespace Modules.Estates.Domain.Entities.Setup.Property;

public class FloorNumbering : AuditableEntity
{
    [Key]
    [Required]
    public int FloorNumberId { get; set; }

    [StringLength(25)]
    [Required]
    public string? FloorNumber { get; set; }

    public FloorNumbering(int floorNumberId, string floorNumber)
    {
        FloorNumberId = floorNumberId;
        FloorNumber = floorNumber;
    }

    public static FloorNumbering Create(int floorNumberId, string floorNumber)
    {
        if (string.IsNullOrWhiteSpace(floorNumber) || floorNumberId < 0)
        {
            throw new ArgumentException("Invalid Floor Number Data.");
        }

        if (floorNumberId <= -1)
            throw new ArgumentException("Floor Number Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(floorNumber) || floorNumber.Length > 25)
            throw new ArgumentException("Floor Number must not be null or exceed 25 characters.");


        return new FloorNumbering(floorNumberId, floorNumber);
    }

    public static FloorNumbering Update(int floorNumberId, string floorNumber)
    {
        if (string.IsNullOrWhiteSpace(floorNumber) || floorNumberId < 0)
        {
            throw new ArgumentException("Invalid Floor Number Data.");
        }

        if (floorNumberId <= -1)
            throw new ArgumentException("Floor Number Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(floorNumber) || floorNumber.Length > 25)
            throw new ArgumentException("Floor Number must not be null or exceed 25 characters.");


        return new FloorNumbering(floorNumberId, floorNumber);
    }
}

