// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/LandUseType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class LandUseType : AuditableEntity
{
    [Required]
    public int LandUseId { get; private set; }

    [Key]
    [Required]
    public int LandUseTypeId { get; private set; }

    [Required]
    [StringLength(5)]
    public string LandUseTypeInitial { get; private set; }

    [Required]
    [StringLength(30)]
    public string LandUseTypeName { get; private set; }

    public LandUseType(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName)
    {
        LandUseId = landUseId;
        LandUseTypeId = landUseTypeId;
        LandUseTypeInitial = landUseTypeInitial;
        LandUseTypeName = landUseTypeName;
    }

    public static LandUseType Create(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName)
    {
        Validate(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName);
        return new LandUseType(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName);
    }

    public void Update(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName)
    {
        Validate(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName);

        LandUseId = landUseId;
        LandUseTypeId = landUseTypeId;
        LandUseTypeInitial = landUseTypeInitial;
        LandUseTypeName = landUseTypeName;
    }

    private static void Validate(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName)
    {
        if (landUseId < 0)
            throw new ArgumentException("Land Use Id must be greater than zero.");

        if (landUseTypeId < 0)
            throw new ArgumentException("Land Use Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(landUseTypeInitial))
            throw new ArgumentException("Land Use Type Initial cannot be empty or exceed 5 characters..");

        if (string.IsNullOrWhiteSpace(landUseTypeName))
            throw new ArgumentException("Land Use Type Name cannot be empty or exceed 50 characters..");
    }
}

