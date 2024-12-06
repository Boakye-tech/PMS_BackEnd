using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class ChartOfAccounts : AuditableEntity
{
    [Key]
    [Required]
    public required int AccountCode { get; set; }

    [StringLength(50)]
    [Required]
    public required string AccountName { get; set; }
}

