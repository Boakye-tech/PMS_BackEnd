using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class Nationality : AuditableEntity
{
    [Key]
    [Required]
    public int NationalityId { get; set; }

    [Required]
    [StringLength(50)]
    public string Nationalities { get; set; }

    public Nationality(int nationalityId, string nationalities)
    {
        NationalityId = nationalityId;
        Nationalities = nationalities;
    }

    public static Nationality Create(int nationalityId, string nationalities)
    {
        if (string.IsNullOrWhiteSpace(nationalities) || nationalityId < 0)
        {
            throw new ArgumentException("Invalid Nationality Data.");
        }

        if (nationalityId <= -1)
            throw new ArgumentException("Nationality Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(nationalities) || nationalities.Length > 50)
            throw new ArgumentException("Nationality must not be null or exceed 50 characters.");


        return new Nationality(nationalityId, nationalities);
    }

    public static Nationality Update(int nationalityId, string nationalities)
    {
        if (string.IsNullOrWhiteSpace(nationalities) || nationalityId < 0)
        {
            throw new ArgumentException("Invalid Nationality Data.");
        }

        if (nationalityId <= -1)
            throw new ArgumentException("Nationality Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(nationalities) || nationalities.Length > 50)
            throw new ArgumentException("Nationality must not be null or exceed 50 characters.");


        return new Nationality(nationalityId, nationalities);
    }
}


