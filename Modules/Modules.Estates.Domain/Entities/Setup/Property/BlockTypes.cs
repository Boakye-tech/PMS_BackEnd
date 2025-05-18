using System;// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:05 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockTypes : AuditableEntity
{
    [Key]
    [Required]
    public int BlockTypeId { get; private set; }

    [Required]
    [StringLength(20)]
    public string BlockType { get; private set; }

    public BlockTypes(int blockTypeId, string blockType)
    {
        BlockTypeId = blockTypeId;
        BlockType = blockType;
    }

    public static BlockTypes Create(int blockTypeId, string blockType)
    {
        Validate(blockTypeId, blockType);
        return new BlockTypes(blockTypeId, blockType);
    }

    public void Update(int blockTypeId, string blockType)
    {
        Validate(blockTypeId, blockType);

        BlockTypeId = blockTypeId;
        BlockType = blockType;
    }

    private static void Validate(int blockTypeId, string blockType)
    {
        if (blockTypeId < 0)
            throw new ArgumentException("Block Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockType) || blockType.Length > 20)
            throw new ArgumentException("Block Type cannot be empty or exceed 20 characters.");
    }
}

