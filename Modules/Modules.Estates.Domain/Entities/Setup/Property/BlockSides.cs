// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockSides.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class BlockSides : AuditableEntity
{
    [Key]
    [Required]
    public int SideId { get; private set; }

    [Required]
    [StringLength(10)]
    public string Side { get; private set; }

    public BlockSides(int sideId, string side)
    {
        SideId = sideId;
        Side = side;
    }

    public static BlockSides Create(int sideId, string side)
    {
        Validate(sideId, side);
        return new BlockSides(sideId, side);
    }

    public void Update(int sideId, string side)
    {
        Validate(sideId, side);

        SideId = sideId;
        Side = side;
    }

    private static void Validate(int sideId, string side)
    {
        if (sideId < 0)
            throw new ArgumentException("Block Side Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(side) ||side.Length > 10)
            throw new ArgumentException("Block Side cannot be empty or exceed 10 characters.");
    }
}

