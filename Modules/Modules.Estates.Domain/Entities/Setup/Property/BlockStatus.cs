using System;// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockStatus.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockStatus : AuditableEntity
{
    [Key]
    [Required]
    public int BlockStatusId { get; private set; }

    [Required]
    [StringLength(25)]
    public string BlockStatusType { get; private set; }

    public BlockStatus(int blockStatusId, string blockStatusType)
    {
        BlockStatusId = blockStatusId;
        BlockStatusType = blockStatusType;
    }

    public static BlockStatus Create(int blockStatusId, string blockStatusType)
    {
        Validate(blockStatusId, blockStatusType);
        return new BlockStatus(blockStatusId, blockStatusType);
    }

    public void Update(int blockStatusId, string blockStatusType)
    {
        Validate(blockStatusId, blockStatusType);

        BlockStatusId = blockStatusId;
        BlockStatusType = blockStatusType;
    }

    private static void Validate(int blockStatusId, string blockStatusType)
    {
        if (blockStatusId < 0)
            throw new ArgumentException("Block Status Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(blockStatusType) || blockStatusType.Length > 25)
            throw new ArgumentException("Block Status Type cannot be empty or exceed 25 characters.");
    }
}

