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
    public string? LandUseTypeInitial { get; private set; }

    [Required]
    [StringLength(30)]
    public string? LandUseTypeName { get; private set; }


    public LandUseType(int landUseId, int landUseTypeId, string? landUseTypeInitial, string? landUseTypeName)
    {
        LandUseId = landUseId;
        LandUseTypeId = landUseTypeId;
        LandUseTypeInitial = landUseTypeInitial;
        LandUseTypeName = landUseTypeName;
    }

    public static LandUseType Create(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName)
    {
        if (string.IsNullOrWhiteSpace(landUseTypeInitial) || string.IsNullOrWhiteSpace(landUseTypeName) || landUseId < 0 || landUseTypeId < 0)
        {
            throw new ArgumentException("Invalid Land Use Type Data.");
        }

        if (landUseId <= -1)
        {
            throw new ArgumentException("Land Use Id must be greater than zero.");
        }

        if (landUseTypeId <= -1)
        {
            throw new ArgumentException("Land Use Type Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(landUseTypeInitial) || landUseTypeInitial.Length > 5)
        {
            throw new ArgumentException("Land Use Type Initial must not be null or exceed 5 characters.");
        }

        if (string.IsNullOrWhiteSpace(landUseTypeName) || landUseTypeName.Length > 50)
        {
            throw new ArgumentException("Land Use Type must not be null or exceed 50 characters.");
        }

        return new LandUseType(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName);
    }


    public static LandUseType Update(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName)
    {
        if (string.IsNullOrWhiteSpace(landUseTypeInitial) || string.IsNullOrWhiteSpace(landUseTypeName) || landUseId < 0 || landUseTypeId < 0)
        {
            throw new ArgumentException("Invalid Land Use Type Data.");
        }

        if (landUseId <= -1)
        {
            throw new ArgumentException("Land Use Id must be greater than zero.");
        }

        if (landUseTypeId <= -1)
        {
            throw new ArgumentException("Land Use Type Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(landUseTypeInitial) || landUseTypeInitial.Length > 5)
        {
            throw new ArgumentException("Land Use Type Initial must not be null or exceed 5 characters.");
        }

        if (string.IsNullOrWhiteSpace(landUseTypeName) || landUseTypeName.Length > 50)
        {
            throw new ArgumentException("Land Use Type must not be null or exceed 50 characters.");
        }

        return new LandUseType(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName);
    }

}

