using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class ResidentType : AuditableEntity
{
    [Key]
    [Required]
    public int ResidentTypeId { get; set; }

    [Required]
    [StringLength(50)]
    public string ResidentTypes { get; set; }

    public ResidentType(int residentTypeId, string residentTypes)
    {
        ResidentTypeId = residentTypeId;
        ResidentTypes = residentTypes;
    }

    public static ResidentType Create(int residentTypeId, string residentTypes)
    {
        if (string.IsNullOrWhiteSpace(residentTypes) || residentTypeId < 0)
        {
            throw new ArgumentException("Invalid Resident Type Data.");
        }

        if (residentTypeId <= -1)
            throw new ArgumentException("Resident Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(residentTypes) || residentTypes.Length > 50)
            throw new ArgumentException("Resident Type must not be null or exceed 50 characters.");


        return new ResidentType(residentTypeId, residentTypes);
    }

    public static ResidentType Update(int residentTypeId, string residentTypes)
    {
        if (string.IsNullOrWhiteSpace(residentTypes) || residentTypeId < 0)
        {
            throw new ArgumentException("Invalid Resident Type Data.");
        }

        if (residentTypeId <= -1)
            throw new ArgumentException("Resident Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(residentTypes) || residentTypes.Length > 50)
            throw new ArgumentException("Resident Type must not be null or exceed 50 characters.");


        return new ResidentType(residentTypeId, residentTypes);
    }
}

