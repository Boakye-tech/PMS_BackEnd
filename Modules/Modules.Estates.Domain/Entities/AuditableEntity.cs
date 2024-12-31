
namespace Modules.Estates.Domain.Entities;

public class AuditableEntity
{
    public DateTime CreatedOn { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime DeletedOn { get; set; }
    public string? DeletedBy { get; set; }

}


public class BaseEntity : AuditableEntity
{
    public DateTime ApprovedOn { get; set; }
    public string? ApprovedBy { get; set; }
}
