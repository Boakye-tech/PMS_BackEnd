namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockStatus
{
    [Key]
    public int BlockStatusId { get; set; }

    [StringLength(25)]
    public string? BlockStatusType { get; set; }

    public BlockStatus(int blockStatusId, string blockStatusType)
	{
        BlockStatusId = blockStatusId;
        BlockStatusType = blockStatusType;

    }

    public static BlockStatus Create(int blockStatusId, string blockStatusType)
    {
        if (string.IsNullOrWhiteSpace(blockStatusType) || blockStatusId < 0)
        {
            throw new ArgumentException("Invalid Block Status Data.");
        }

        if (blockStatusId <= -1)
            throw new ArgumentException("Block Status Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockStatusType) || blockStatusType.Length > 25)
            throw new ArgumentException("Block Status must not be null or exceed 25 characters.");


        return new BlockStatus(blockStatusId, blockStatusType);
    }

    public static BlockStatus Update(int blockStatusId, string blockStatusType)
    {
        if (string.IsNullOrWhiteSpace(blockStatusType) || blockStatusId < 0)
        {
            throw new ArgumentException("Invalid Block Status Data.");
        }

        if (blockStatusId <= -1)
            throw new ArgumentException("Block Status Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockStatusType) || blockStatusType.Length > 25)
            throw new ArgumentException("Block Status must not be null or exceed 25 characters.");


        return new BlockStatus(blockStatusId, blockStatusType);
    }

}

