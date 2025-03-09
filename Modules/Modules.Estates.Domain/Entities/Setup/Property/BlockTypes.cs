namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockTypes : AuditableEntity
{
    [Key]
    [Required]
    public int BlockTypeId { get; set; }

    [Required]
    [StringLength(20)]
    public string BlockType { get; set; }

    public BlockTypes(int blockTypeId, string blockType)
    {
        BlockTypeId = blockTypeId;
        BlockType = blockType;
    }

    public static BlockTypes Create(int blockTypeId, string blockType)
    {
        if (string.IsNullOrWhiteSpace(blockType) || blockTypeId < 0)
        {
            throw new ArgumentException("Invalid Block Type Data.");
        }

        if (blockTypeId <= -1)
            throw new ArgumentException("Block Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockType) || blockType.Length > 10)
            throw new ArgumentException("Block Types must not be null or exceed 20 characters.");


        return new BlockTypes(blockTypeId, blockType);
    }

    public static BlockTypes Update(int blockTypeId, string blockType)
    {
        if (string.IsNullOrWhiteSpace(blockType) || blockTypeId < 0)
        {
            throw new ArgumentException("Invalid Block Type Data.");
        }

        if (blockTypeId <= -1)
            throw new ArgumentException("Block Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockType) || blockType.Length > 10)
            throw new ArgumentException("Block Types must not be null or exceed 20 characters.");


        return new BlockTypes(blockTypeId, blockType);
    }


}

