namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockNumber: AuditableEntity
{
    [Key]
    [Required]
    public int BlockNumberId { get; set; }


    [Required]
    [StringLength(5)]
    public string BlockNumbers { get; set; }

    public BlockNumber(int blockNumberId, string blockNumbers)
    {
        BlockNumberId = blockNumberId;
        BlockNumbers = blockNumbers;
    }

    public static BlockNumber Create(int blockNumberId, string blockNumbers)
    {
        if (string.IsNullOrWhiteSpace(blockNumbers) || blockNumberId < 0)
        {
            throw new ArgumentException("Invalid Block Numbers Data.");
        }

        if (blockNumberId <= -1)
            throw new ArgumentException("Block Number Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockNumbers) || blockNumbers.Length > 5)
            throw new ArgumentException("Block Numbers must not be null or exceed 5 characters.");


        return new BlockNumber(blockNumberId, blockNumbers);
    }


    public static BlockNumber Update(int blockNumberId, string blockNumbers)
    {
        if (string.IsNullOrWhiteSpace(blockNumbers) || blockNumberId < 0)
        {
            throw new ArgumentException("Invalid Block Numbers Data.");
        }

        if (blockNumberId <= -1)
            throw new ArgumentException("Block Number Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockNumbers) || blockNumbers.Length > 5)
            throw new ArgumentException("Block Numbers must not be null or exceed 5 characters.");


        return new BlockNumber(blockNumberId, blockNumbers);
    }


}

