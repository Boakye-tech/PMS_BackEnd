using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Modules.Estates.Domain.Entities.Setup.Property;

/*
	public class LandUse : AuditableEntity
{
    [Key]
    [Required]
    public required int LandUseId { get; set; }

    [Required]
    [StringLength(5)]
    public required string LandUseInitial { get; set; }

    [Required]
    [StringLength(30)]
    public required string LandUseName { get; set; }
}
*/

public class LandUse : AuditableEntity
{
    [Key]
    [Required]
    public int LandUseId { get; private set; }

    [Required]
    [StringLength(5)]
    public string? LandUseInitial { get; private set; }

    [Required]
    [StringLength(50)]
    public string? LandUseName { get; private set; }

    //public LandUse(int landUseId, string landUseInitial, string landUseName)
    //{
    //    LandUseId = landUseId;
    //    LandUseInitial = landUseInitial ?? throw new ArgumentNullException(nameof(landUseInitial));
    //    LandUseName = landUseName ?? throw new ArgumentNullException(nameof(landUseName));
    //}

    public LandUse(int landUseId, string landUseInitial, string landUseName)
    {
        LandUseId = landUseId;
        LandUseInitial = landUseInitial ?? throw new ArgumentNullException(nameof(landUseInitial));
        LandUseName = landUseName ?? throw new ArgumentNullException(nameof(landUseName));
    }


    public static LandUse Create(int landUseId, string landUseInitial, string landUseName)
    {
        if (string.IsNullOrWhiteSpace(landUseInitial) || string.IsNullOrWhiteSpace(landUseName) || landUseId < 0)
        {
            throw new ArgumentException("Invalid Land Use Data.");
        }

        if (landUseId <= -1)
            throw new ArgumentException("Land Use Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(landUseInitial) || landUseInitial.Length > 5)
            throw new ArgumentException("Land Use Initial must not be null or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(landUseName) || landUseName.Length > 50)
            throw new ArgumentException("Land Use Name must not be null or exceed 50 characters.");

        return new LandUse(landUseId,landUseInitial, landUseName);
    }

    public LandUse Update(int landUseId, string landUseInitial, string landUseName)
    {
        if (string.IsNullOrWhiteSpace(landUseInitial) || string.IsNullOrWhiteSpace(landUseName) || landUseId < 0)
        {
            throw new ArgumentException("Invalid Land Use Data.");
        }

        if (landUseId <= -1)
            throw new ArgumentException("Land Use Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(landUseInitial) || landUseInitial.Length > 5)
            throw new ArgumentException("Land Use Initial must not be null or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(landUseName) || landUseName.Length > 50)
            throw new ArgumentException("Land Use Name must not be null or exceed 50 characters.");

        return new LandUse(landUseId, landUseInitial, landUseName);
    }

}

