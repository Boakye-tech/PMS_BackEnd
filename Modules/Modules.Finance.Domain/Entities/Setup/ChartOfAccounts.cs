using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class ChartOfAccounts : AuditableEntity
{
    [Key]
    [Required]
    public int AccountCode { get; set; }

    [StringLength(50)]
    [Required]
    public string? AccountName { get; set; }

    public ChartOfAccounts(int accountCode, string accountName)
    {
        AccountCode = accountCode;
        AccountName = accountName;
    }


    public static ChartOfAccounts CreateUpdate(int accountCode, string accountName)
    {
        if (string.IsNullOrWhiteSpace(accountName) || accountCode < 0)
        {
            throw new ArgumentException("Invalid chart of accounts data.");
        }

        if (accountCode <= 0)
            throw new ArgumentException("The chart of account code must be greater than zero.");

        if (string.IsNullOrWhiteSpace(accountName) || accountName.Length > 50)
            throw new ArgumentException("The chart of account name must not be null or exceed 50 characters.");


        return new ChartOfAccounts(accountCode, accountName);
    }
}

