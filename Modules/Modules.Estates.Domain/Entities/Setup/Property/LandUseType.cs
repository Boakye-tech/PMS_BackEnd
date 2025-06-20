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

    // Navigation property for LandUse
    public virtual LandUse? LandUse { get; private set; }

    [Required]
    [StringLength(5)]
    public string? LandUseTypeInitial { get; private set; }

    [Required]
    [StringLength(30)]
    public string? LandUseTypeName { get; private set; }

    [StringLength(250)]
    public string? LandUseTypeDescription { get; private set; }


    public LandUseType(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName, string landUseTypeDescription)
    {
        LandUseId = landUseId;
        LandUseTypeId = landUseTypeId;
        LandUseTypeInitial = landUseTypeInitial;
        LandUseTypeName = landUseTypeName;
        LandUseTypeDescription = landUseTypeDescription;
    }

    public static LandUseType Create(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName, string landUseTypeDescription)
    {
        Validate(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName, landUseTypeDescription);
        return new LandUseType(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName, landUseTypeDescription);
    }

    public void Update(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName, string landUseTypeDescription)
    {
        Validate(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName, landUseTypeDescription);

        LandUseId = landUseId;
        LandUseTypeId = landUseTypeId;
        LandUseTypeInitial = landUseTypeInitial;
        LandUseTypeName = landUseTypeName;
        LandUseTypeDescription = landUseTypeDescription;
    }

    private static void Validate(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName, string landUseTypeDescription)
    {
        if (landUseId <= 0)
            throw new ArgumentException("Land Use Id must be greater than zero.");

        if (landUseTypeId < 0)
            throw new ArgumentException("Land Use Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(landUseTypeInitial) || landUseTypeInitial.Length > 5)
            throw new ArgumentException("Land Use Type Initial cannot be empty or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(landUseTypeName) || landUseTypeName.Length > 50)
            throw new ArgumentException("Land Use Type Name cannot be empty or exceed 50 characters.");

        if (!string.IsNullOrWhiteSpace(landUseTypeDescription) && landUseTypeDescription.Length > 250)
            throw new ArgumentException("Land Use Type Description cannot be empty or exceed 250 characters.");

    }
}

