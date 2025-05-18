// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockNumber.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockNumber : AuditableEntity
{
    [Key]
    [Required]
    public int BlockNumberId { get; private set; }

    [Required]
    [StringLength(5)]
    public string BlockNumbers { get; private set; }

    public BlockNumber(int blockNumberId, string blockNumbers)
    {
        BlockNumberId = blockNumberId;
        BlockNumbers = blockNumbers;
    }

    public static BlockNumber Create(int blockNumberId, string blockNumbers)
    {
        Validate(blockNumberId, blockNumbers);
        return new BlockNumber(blockNumberId, blockNumbers);
    }

    public void Update(int blockNumberId, string blockNumbers)
    {
        Validate(blockNumberId, blockNumbers);

        BlockNumberId = blockNumberId;
        BlockNumbers = blockNumbers;
    }

    private static void Validate(int blockNumberId, string blockNumbers)
    {
        if (blockNumberId < 0)
            throw new ArgumentException("Block Number Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockNumbers) || blockNumbers.Length > 5)
            throw new ArgumentException("Block Numbers cannot be empty or exceed 5 characters.");
    }
}

