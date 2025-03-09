namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class Title : AuditableEntity
{
    [Key]
    [Required]
    public int TitleId { get; set; }

    [Required]
    [StringLength(20)]
    public string Titles { get; set; }

    public Title(int titleId, string titles)
    {
        TitleId = titleId;
        Titles = titles;
    }

    public static Title Create(int titleId, string titles)
    {
        if (string.IsNullOrWhiteSpace(titles) || titleId < 0)
        {
            throw new ArgumentException("Invalid Title Data.");
        }

        if (titleId <= -1)
            throw new ArgumentException("Title Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(titles) || titles.Length > 20)
            throw new ArgumentException("Title must not be null or exceed 20 characters.");


        return new Title(titleId, titles);
    }

    public static Title Update(int titleId, string titles)
    {
        if (string.IsNullOrWhiteSpace(titles) || titleId < 0)
        {
            throw new ArgumentException("Invalid Title Data.");
        }

        if (titleId <= -1)
            throw new ArgumentException("Title Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(titles) || titles.Length > 20)
            throw new ArgumentException("Title must not be null or exceed 20 characters.");


        return new Title(titleId, titles);
    }
}

