namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class Gender : AuditableEntity
{
    [Key]
    [Required]
    public int GenderId { get; set; }

    [Required]
    [StringLength(10)]
    public string GenderType { get; set; }

    public Gender(int genderId, string genderType)
    {
        GenderId = genderId;
        GenderType = genderType;
    }

    public static Gender Create(int genderId, string genderType)
    {
        if (string.IsNullOrWhiteSpace(genderType) || genderId < 0)
        {
            throw new ArgumentException("Invalid Gender Data.");
        }

        if (genderId <= -1)
            throw new ArgumentException("Gender Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(genderType) || genderType.Length > 10)
            throw new ArgumentException("Gender must not be null or exceed 10 characters.");


        return new Gender(genderId, genderType);
    }

    public static Gender Update(int genderId, string genderType)
    {
        if (string.IsNullOrWhiteSpace(genderType) || genderId < 0)
        {
            throw new ArgumentException("Invalid Gender Data.");
        }

        if (genderId <= -1)
            throw new ArgumentException("Gender Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(genderType) || genderType.Length > 10)
            throw new ArgumentException("Gender must not be null or exceed 10 characters.");


        return new Gender(genderId, genderType);
    }

}

