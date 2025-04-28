// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

