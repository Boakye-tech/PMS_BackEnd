using System;
namespace Modules.Estates.Domain.Entities.Setup.Property;

public class Facilities : AuditableEntity
{
    [Key]
    public int FacilityId { get; set; }

    [Required]
    [StringLength(20)]
    public string Facility { get; set; }

    public Facilities(int facilityId, string facility)
	{
        FacilityId = facilityId;
        Facility = facility;
    }

    public static Facilities Create(int facilityId, string facility)
    {
        if (string.IsNullOrWhiteSpace(facility) || facilityId < 0)
        {
            throw new ArgumentException("Invalid Facility Data.");
        }

        if (facilityId <= -1)
            throw new ArgumentException("Facility Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(facility) || facility.Length > 20)
            throw new ArgumentException("Facility must not be null or exceed 20 characters.");


        return new Facilities(facilityId, facility);
    }


    public static Facilities Update(int facilityId, string facility)
    {
        if (string.IsNullOrWhiteSpace(facility) || facilityId < 0)
        {
            throw new ArgumentException("Invalid Facility Data.");
        }

        if (facilityId <= -1)
            throw new ArgumentException("Facility Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(facility) || facility.Length > 20)
            throw new ArgumentException("Facility must not be null or exceed 20 characters.");


        return new Facilities(facilityId, facility);
    }
}

